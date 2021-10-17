namespace Blogapp.Domain.Entities.Entiti.DTOs
{
    public class LocationDTO
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public Location ToLocation()
        {
            return new Location { Latitude = this.Latitude, Longitude = this.Longitude };
        }
    }
}
