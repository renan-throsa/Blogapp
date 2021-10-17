using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization.Conventions;
using Blogapp.Domain.Entities.Exceptions;
using MongoDB.Bson.Serialization;
using Blogapp.Domain.Entities.Entiti;
using Blogapp.Domain.Repositories.Impl.Mapping;

namespace Blogapp.Domain.Repositories
{
    public class BlogappContext
    {
        private readonly IConfiguration Configuration;
        private readonly string _connectionString;
        private readonly MongoClientSettings _settings;
        private readonly string _nameDB;
        private static bool _MongoMapped = false;

        private IMongoDatabase _dataBase;
        public IMongoDatabase DataBase
        {
            get { return _dataBase ?? (_dataBase = Cliente.GetDatabase(_nameDB)); }
        }


        private IMongoClient _cliente;

        public IMongoClient Cliente
        {
            get { return _cliente ??= new MongoClient(_settings); }

        }

        public BlogappContext(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration.GetSection("BlogappContext:ConnectionString").Value;
            _settings = MongoClientSettings.FromUrl(new MongoUrl(_connectionString));
            _nameDB = Configuration.GetSection("BlogappContext:DatabaseName").Value;
            RegisterMongoMap();
            Conectar();            
        }

        public void Conectar()
        {
            if (DataBase == null)
                throw new MongoConnectionFailedException("Não foi possível conectar ao banco de dados.");
            ConventionPack pack = new ConventionPack
            {
                new CamelCaseElementNameConvention()
            };
            ConventionRegistry.Register("camelCase", pack, _ => true);
        }


        private void RegisterMongoMap()
        {
            _MongoMapped = true;
            if (!_MongoMapped)
            {
                //.RegisterSerializer(typeof(DateTime), new LocalTimeMongoSerializer());

                BsonClassMap.RegisterClassMap<BaseEntity>(cm => MongoMapping.BaseEntity(cm));
                BsonClassMap.RegisterClassMap<User>(cm => MongoMapping.User(cm));
            }
        }

    }
}
