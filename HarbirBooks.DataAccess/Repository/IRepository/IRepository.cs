﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HarbirBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null 
            );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string inculdeProperties = null
            );
        void Add(T entity);                 // add entity
        void Remove(int id);                // remove an object
        void Remove(T entity);              // another way to remove an object 
        void Removerange(IEnumerable<T> entity);  // remove complete range of entities

    }
}