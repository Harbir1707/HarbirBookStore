using System;
using System.Collections.Generic;
using System.Text;
using HarbirBooks.Models;
using HarbirBooks.Models.ViewModels;

namespace HarbirBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);

    }
}
