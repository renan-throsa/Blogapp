using Blogapp.Domain.Entities.Entiti;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogapp.Domain.Entities.Entities
{
    public class Like : BaseEntity
    {
        public ObjectId UserId { get; set; }
        public ObjectId PostId { get; set; }

    }
}
