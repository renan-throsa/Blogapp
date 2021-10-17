namespace Blogapp.Domain.Entities.Entiti
{
    class Follow
    {
        public User Follower { get; set; }
        public User Followed { get; set; }

    }
}
