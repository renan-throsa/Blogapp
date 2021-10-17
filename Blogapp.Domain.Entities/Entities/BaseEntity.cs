using MongoDB.Bson;

namespace Blogapp.Domain.Entities.Entiti
{
    public abstract class BaseEntity
    {       
        public ObjectId Id { get; set; }
    }
}
