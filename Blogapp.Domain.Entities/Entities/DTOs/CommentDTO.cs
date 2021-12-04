using Blogapp.Domain.Entities.Entities;
using MongoDB.Bson;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blogapp.Domain.Entities.Entiti.DTOs
{
    public class CommentDTO : BaseDTO<Comment>
    {
        public override Comment ToEntity()
        {
            return new Comment
            {
                Id = this.Id == null ? ObjectId.Empty : ObjectId.Parse(this.Id),
                Body = this.Body,
                TimeStamp = this.TimeStamp,
                Post = this.Post?.ToEntity(),
                User = this.User?.ToEntity(),
            };
        }

        public PostDTO Post { get; set; }
        public UserDTO User { get; set; }

        [StringLength(maximumLength: 200, MinimumLength = 2,
        ErrorMessage = "O corpo deve ter no mímino 2 caracteres e no máximo 200.")]
        public string Body { get; set; }
        public DateTime TimeStamp { get; set; }
    }

}
