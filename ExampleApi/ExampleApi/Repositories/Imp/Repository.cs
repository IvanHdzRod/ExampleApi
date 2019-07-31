
using ExampleApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.API.Repositories.Imp
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ExampleContext _db;
        protected readonly DbSet<T> dbSet;

        public Repository(ExampleContext db)
        {
            this._db = db;
            dbSet = db.Set<T>();
        }

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual T Get(Guid id)
        {
            return dbSet.Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return dbSet.AsQueryable();
        }

        public virtual async Task<T> GetAsync(Guid id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
