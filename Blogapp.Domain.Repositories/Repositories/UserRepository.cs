using Blogapp.Domain.Entities.Entiti;
using Blogapp.Domain.Repositories.Contract.Interfaces;
using Blogapp.Domain.Repositories.Repositories;

namespace Blogapp.Domain.Repositories.Impl.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(BlogappContext context) : base(context)
        {
        }
    }
}
