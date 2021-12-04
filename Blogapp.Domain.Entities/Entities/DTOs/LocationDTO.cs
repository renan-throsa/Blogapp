using Blogapp.Domain.Entities.Entities;
using System.ComponentModel.DataAnnotations;

namespace Blogapp.Domain.Entities.Entiti.DTOs
{
    public class LocationDTO
    {
        [Range(-90, 90, ErrorMessage = "Latitude precisa ser um número entre -90 e 90.")]
        public float Latitude { get; set; }

        [Range(-180, 180, ErrorMessage = "Longitude precisa ser um número entre -180 e 180.")]
        public float Longitude { get; set; }

        public Location ToLocation()
        {
            return new Location { Latitude = this.Latitude, Longitude = this.Longitude };
        }
    }
}
