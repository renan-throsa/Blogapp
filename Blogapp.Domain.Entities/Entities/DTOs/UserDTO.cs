using Blogapp.Domain.Entities.Entities;
using MongoDB.Bson;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blogapp.Domain.Entities.Entiti.DTOs
{
    public class UserDTO : BaseDTO<User>
    {
        public override User ToEntity()
        {
            return new User
            {
                Id = this.Id == null ? ObjectId.Empty : ObjectId.Parse(this.Id),
                About = this.About,
                Name = this.Name,
                Location = this.Location.ToLocation(),
                Joint = this.Joint,
                LastSeen = this.LastSeen,
                BirthDate = this.BirthDate,
            };
        }

        [RegularExpression(@"[\w\u00C0-\u00D6\u00D8-\u00f6\u00f8-\u00ff\s]{5,50}$",
         ErrorMessage = "O nome do usuario deve ter no mímino 10 caracteres e no máximo 50 e conter somente letras.")]
        public string Name { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public LocationDTO Location { get; set; }

        [MaxLength(200, ErrorMessage = "Seção 'sobre' pode ter no máximo 200 caracteres")]
        public string About { get; set; }
        public DateTime Joint { get; set; }
        public DateTime LastSeen { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
