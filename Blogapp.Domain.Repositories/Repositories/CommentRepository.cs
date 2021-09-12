using Blogapp.Domain.Entities.Entities;
using Blogapp.Domain.Repositories.Contract.Interfaces;
using Blogapp.Domain.Repositories.Repositories;

namespace Blogapp.Domain.Repositories.Impl.Repositories
{
    class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(BlogappContext context) : base(context)
        {
        }
    }
}
