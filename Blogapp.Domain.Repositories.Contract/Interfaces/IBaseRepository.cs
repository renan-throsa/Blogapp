using Blogapp.Domain.Entities.Entiti;
using Blogapp.Domain.Entities.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blogapp.Domain.Repositories.Contract.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IList<T> All();

        Task<List<T>> AllAsync();

        ObjectId Add(T entity);

        IEnumerable<ObjectId> Add(params T[] entities);

        IEnumerable<ObjectId> Add(IEnumerable<T> entities);

        IMongoCollection<T> CreateCollection();

        void Delete(T entity);

        void Delete(IEnumerable<T> entities);

        void DeleteByKey(ObjectId key);

        void DeleteManyByKey(IEnumerable<ObjectId> ids);
        
        void DeleteByKey(string key);

        void Delete(Expression<Func<T, bool>> filterExpression);

        void Edit(ObjectId id, T entidade);

        bool Edit(T entidade);

        void Edit(IEnumerable<T> entidades);

        IEnumerable<T> Filter(Func<T, bool> filtro = null);
        
        IEnumerable<T> Find(Expression<Func<T, bool>> filtro = null);

        T FindByKey(ObjectId key);
        
        T FindByKey(string key);
    }
}
