using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStatus.Data.Contract;

namespace UserStatus.Data
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private DbContext _dbContext;
        private DbSet<T> _dbSet;

        public EFRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Create(T entity)
        {
            var entry = _dbContext.Entry(entity);
            entry.State = EntityState.Added;
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            var entry = _dbContext.Entry(entity);
            _dbSet.Attach(entity);
            entry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            var entry = _dbContext.Entry(entity);
            entry.State = EntityState.Deleted;
            _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
                Delete(entity);
        }

    }
}
