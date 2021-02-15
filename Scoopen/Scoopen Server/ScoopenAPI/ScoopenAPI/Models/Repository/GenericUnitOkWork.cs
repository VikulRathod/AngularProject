using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoopenAPI.Models.Repository
{
    public class GenericUnitOkWork
    {
        ScoopenDB _db = new ScoopenDB();

        public GenericRepository<TEntity> GetRepositoryInstance<TEntity>()
            where TEntity : class
        {
            return new GenericRepository<TEntity>(_db);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}