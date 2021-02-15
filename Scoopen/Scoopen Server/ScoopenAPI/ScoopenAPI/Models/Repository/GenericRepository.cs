using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScoopenAPI.Models.Repository
{
    public class GenericRepository<TEntity> : 
        IGenericRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> _dbSet;

        ScoopenDB _db;

        public GenericRepository(ScoopenDB db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> GetAllRecords()
        {
            return _dbSet.ToList();
        }

        public TEntity GetFirstOrDefault(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}