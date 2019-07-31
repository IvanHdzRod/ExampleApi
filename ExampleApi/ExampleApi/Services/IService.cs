using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.API.Services
{
    public interface IService<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task DeleteAsync(Guid id);
        IQueryable<T> GetAll();
        Task<T> GetAsync(Guid id);
        Task<T> UpdateAsync(Guid id, T entity);
    }
}
