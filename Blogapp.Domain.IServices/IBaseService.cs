using MongoDB.Bson;
using System.Collections.Generic;

namespace Blogapp.Domain.IServices
{
    public interface IBaseService<DTO>
    {
        ObjectId Add(DTO dto);
        IEnumerable<DTO> Browse();
        DTO Read(string id);
        void Edit(DTO dto);
        void Delete(DTO dto);
    }
}
