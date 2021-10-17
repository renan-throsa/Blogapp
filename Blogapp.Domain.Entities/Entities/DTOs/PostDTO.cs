using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogapp.Domain.Entities.Entiti.DTOs
{
    public class PostDTO : BaseDTO<Post>
    {
        public override Post ToEntity()
        {
            return new Post
            {
                Id = this.Id == null ? ObjectId.Empty : ObjectId.Parse(this.Id),
                Body = this.Body,
                Title = this.Title,
                User = this.User?.ToEntity(),
                TimeStamp = this.TimeStamp,
            };
        }

        public UserDTO User { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 2,
        ErrorMessage = "O título deve ter no mímino 2 caracteres e no máximo 200.")]
        public string Title { get; set; }

        [StringLength(maximumLength: 200, MinimumLength = 2,
        ErrorMessage = "O corpo deve ter no mímino 2 caracteres e no máximo 200.")]
        public string Body { get; set; }
        public DateTimeKind TimeStamp { get; set; }
    }
}
