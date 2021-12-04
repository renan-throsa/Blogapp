using MongoDB.Bson;

namespace Blogapp.Domain.Entities.Entities
{
    public abstract class BaseEntity
    {       
        public ObjectId Id { get; set; }
    }
}
