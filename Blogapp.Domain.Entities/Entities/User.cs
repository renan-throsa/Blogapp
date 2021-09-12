using System;

namespace Blogapp.Domain.Entities.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        public string About { get; set; }
        public DateTime Joint { get; set; }
        public DateTime LastSeen { get; set; }
    }
}
