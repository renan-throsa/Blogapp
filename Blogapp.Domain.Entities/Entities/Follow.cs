namespace Blogapp.Domain.Entities.Entities
{
    class Follow
    {
        public User Follower { get; set; }
        public User Followed { get; set; }

    }
}
