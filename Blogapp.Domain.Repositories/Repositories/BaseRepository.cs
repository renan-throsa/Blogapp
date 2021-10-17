using Blogapp.Domain.Entities.Entiti;
using Blogapp.Domain.Repositories.Contract.Exceptions;
using Blogapp.Domain.Repositories.Contract.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blogapp.Domain.Repositories.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public BlogappContext Context { get; }

        private static readonly string CollectionName = $"c_{typeof(T).Name.ToLower()}";

        private IMongoCollection<T> _collection;


        public IMongoCollection<T> Collection
        {
            get { return _collection ?? (_collection = GetOrCreateCollection()); }

        }

        public BaseRepository(BlogappContext context)
        {
            Context = context;
        }
        public virtual IMongoCollection<T> GetOrCreateCollection()
        {
            if (Context.DataBase.GetCollection<T>(CollectionName) == null)
            {
                return CreateCollection();
            }
            return Context.DataBase.GetCollection<T>(CollectionName);
        }

        public ObjectId Add(T entity)
        {
            Collection.InsertOne(entity);
            return entity.Id;
        }

        public IEnumerable<ObjectId> Add(params T[] entities)
        {
            Collection.InsertManyAsync(entities);
            return entities.Select(x => x.Id);
        }

        public IEnumerable<ObjectId> Add(IEnumerable<T> entities)
        {
            Collection.InsertManyAsync(entities);
            return entities.Select(x => x.Id);
        }

        public IList<T> All()
        {
            var colecaoFiltrada = Filter();
            var lista = colecaoFiltrada.ToList();
            return lista;
        }

        public async Task<List<T>> AllAsync()
        {
            return await Collection.Find(new BsonDocument()).ToListAsync();
        }

        protected async Task<List<T>> FindAsync(FilterDefinition<T> filter)
        {
            var lista = await Collection
                .Find(filter)
                .ToListAsync();
            return lista;
        }

        public IMongoCollection<T> CreateCollection()
        {
            Context.DataBase.CreateCollection(CollectionName);
            return Context.DataBase.GetCollection<T>(CollectionName);
        }

        public void Delete(T entity)
        {
            var idObjeto = entity.Id;
            Collection.FindOneAndDelete(x => x.Id == idObjeto);
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach (var ent in entities)
            {
                var idObjeto = ent.Id;
                Collection.DeleteManyAsync(x => x.Id == idObjeto);
            }
        }

        public void Delete(Expression<Func<T, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public void DeleteByKey(ObjectId key)
        {
            Collection.DeleteOne(x => x.Id == key);
        }

        public void DeleteByKey(string key)
        {
            DeleteByKey(ObjectId.Parse(key));
        }

        public void DeleteManyByKey(IEnumerable<ObjectId> ids)
        {
            throw new NotImplementedException();
        }

        public void Edit(ObjectId id, T entidade)
        {
            entidade.Id = id;
            Collection.FindOneAndReplace(x => x.Id == id, entidade);
        }

        public void Edit(T entidade)
        {
            if (entidade.Id == ObjectId.Empty)
            {
                throw new MissingIdOnEntityException();
            }
            Collection.FindOneAndReplace(x => x.Id == entidade.Id, entidade);
        }

        public void Edit(IEnumerable<T> entidades)
        {
            foreach (var ent in entidades)
            {
                Edit(ent);
            }
        }

        public IEnumerable<T> Filter(Func<T, bool> filtro = null)
        {
            
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> filtro = null)
        {
            var resultado = Collection.Find(filtro);
            return resultado.ToEnumerable();
        }

        public T FindByKey(object key)
        {
            var idObjeto = (ObjectId)key;
            return Collection.Find(x => x.Id == idObjeto).FirstOrDefault();
        }

        public T FindByKey(string key)
        {
            if (ObjectId.TryParse(key, out var id))
            {
                return FindByKey(ObjectId.Parse(key));
            }
            throw new ArgumentException($"O Id fornecido não é válido. Id = {key}");
        }


    }
}
