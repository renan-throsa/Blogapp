using Blogapp.Domain.Entities.Entities;
using MongoDB.Bson.Serialization;

namespace Blogapp.Domain.Repositories.Impl.Mapping
{
    public static class MongoMapping
    {
        internal static BsonClassMap<BaseEntity> BaseEntity(BsonClassMap<BaseEntity> cm)
        {
            cm.AutoMap();
            cm.MapMember(c => c.Id).SetElementName("id").SetIgnoreIfDefault(true);
            cm.SetIgnoreExtraElements(true);
            cm.SetIgnoreExtraElementsIsInherited(true); 
            return cm;
        }

        internal static BsonClassMap<User> User(BsonClassMap<User> cm)
        {
            cm.AutoMap();            
            return cm;
        }

        internal static BsonClassMap<Post> Post(BsonClassMap<Post> cm)
        {
            cm.AutoMap();
            return cm;
        }

        internal static BsonClassMap<Comment> Comment(BsonClassMap<Comment> cm)
        {
            cm.AutoMap();
            return cm;
        }

        internal static BsonClassMap<Like> Like(BsonClassMap<Like> cm)
        {
            cm.AutoMap();
            return cm;
        }

        internal static BsonClassMap<Follow> Follow(BsonClassMap<Follow> cm)
        {
            cm.AutoMap();
            return cm;
        }
    }
}
