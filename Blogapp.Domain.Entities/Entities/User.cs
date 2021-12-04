using System;
using System.Collections.Generic;

namespace Blogapp.Domain.Entities.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Location Location { get; set; }
        public string About { get; set; }
        public DateTime Joint { get; set; }
        public DateTime LastSeen { get; set; }
        public DateTime BirthDate { get; set; }

        public IList<Post> Posts { get; set; }
        public IList<User> Followers { get; set; }

    }
}
