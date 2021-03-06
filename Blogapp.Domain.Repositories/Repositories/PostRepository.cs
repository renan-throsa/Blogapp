using Blogapp.Domain.Entities.Entities;
using Blogapp.Domain.Repositories.Repositories;

namespace Blogapp.Domain.Repositories.Impl.Repositories
{
    public class PostRepository : BaseRepository<Post>
    {
        public PostRepository(BlogappContext context) : base(context)
        {
        }
    }
}
