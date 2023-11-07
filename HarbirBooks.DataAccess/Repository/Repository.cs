using HarbirBooks.DataAccess.Repository.IRepository;
using HarbirBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HarbirBooks.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {                   // modify the database w/ db context
        private readonly ApplicationDbContext _db;      // get db instance using the constructor and DI
        internal DbSet<T> dbSet;
        private ApplicationException db;

        public Repository(ApplicationDbContext db)        // use hot keys C-T-O-R to build the constructor
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public Repository(ApplicationException db)
        {
            this.db = db;
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string inculdeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Removerange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
