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
            cm.SetIgnoreExtraElementsIsInherited(true);
            return cm;
        }

        internal static BsonClassMap<User> User(BsonClassMap<User> cm)
        {
            cm.AutoMap();            
            cm.MapMember(c => c.Name).SetElementName("name").SetIgnoreIfDefault(true);
            cm.MapMember(c => c.Location).SetElementName("location").SetIgnoreIfDefault(true);
            cm.MapMember(c => c.Joint).SetElementName("joint").SetIgnoreIfDefault(true);
            return cm;
        }


    }
}
