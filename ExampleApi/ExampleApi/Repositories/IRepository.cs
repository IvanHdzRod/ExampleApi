using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.API.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        Task AddAsync(T entity);
        void Delete(T entity);
        T Get(Guid id);
        IQueryable<T> GetAll();
        Task<T> GetAsync(Guid id);
        void Update(T entity);
    }
}
