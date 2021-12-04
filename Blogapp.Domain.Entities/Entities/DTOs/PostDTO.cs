using Blogapp.Domain.Entities.Entities;
using MongoDB.Bson;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blogapp.Domain.Entities.Entiti.DTOs
{
    public class PostDTO : BaseDTO<Post>
    {
        public override Post ToEntity()
        {
            return new Post
            {
                Id = this.Id == null ? ObjectId.Empty : ObjectId.Parse(this.Id),
                Description = this.Description,
                Picture = this.Picture,
                User = this.User.ToEntity(),
                TimeStamp = this.TimeStamp,
            };
        }

        public UserDTO User { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 2,
        ErrorMessage = "O título deve ter no mímino 2 caracteres e no máximo 200.")]
        public string Picture { get; set; }

        [StringLength(maximumLength: 200, MinimumLength = 2,
        ErrorMessage = "A descrição deve ter no mímino 2 caracteres e no máximo 200.")]
        public string Description { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
