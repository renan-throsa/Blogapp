using Blogapp.Domain.Entities.Entiti;
using Blogapp.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogapp.Domain.Repositories.Contract.Interfaces
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
    }
}
