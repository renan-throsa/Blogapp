using MongoDB.Bson;
using System;

namespace Blogapp.Domain.Entities.Entities
{
    public class Comment : BaseEntity
    {
        public ObjectId PostId { get; set; }
        public Post Post { get; set; }

        public ObjectId UserId { get; set; }
        public User User { get; set; }

        public string Body { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsEdited { get; set; }
    }
}
