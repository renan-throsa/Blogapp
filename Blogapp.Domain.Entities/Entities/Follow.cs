using MongoDB.Bson;
using System;

namespace Blogapp.Domain.Entities.Entities
{
    public class Follow
    {
        public ObjectId FollowerId { get; set; }
        public ObjectId FollowedId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
