using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogapp.Domain.Entities.Entities
{
    public class Post : BaseEntity
    {
        public ObjectId UserId { get; set; }
        public User User { get; set; }

        public string Picture { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
        public DateTime TimeStamp { get; set; }
        public IList<Comment> Comments { get; set; }

    }
}
