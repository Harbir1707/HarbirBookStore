using HarbirBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarbirBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>                               //removed class and modified
    {
        void Update(Category category);
    }
}
