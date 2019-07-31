using Example.API.Repositories;
using Example.API.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.API.Services.Imp
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await _repository.GetAsync(id);
            _repository.Delete(entity);
            await _unitOfWork.SaveAsync();
        }

        public virtual IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual async Task<T> GetAsync(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public virtual async Task<T> UpdateAsync(Guid id, T entity)
        {
            var e = await _repository.GetAsync(id);
            if (e == null)
                throw new Exception();

            _repository.Update(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }
    }
}
