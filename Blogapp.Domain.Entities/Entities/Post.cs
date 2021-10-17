using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogapp.Domain.Entities.Entiti
{
    public class Post : BaseEntity
    {
        public User User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTimeKind TimeStamp { get; set; }
    }
}
