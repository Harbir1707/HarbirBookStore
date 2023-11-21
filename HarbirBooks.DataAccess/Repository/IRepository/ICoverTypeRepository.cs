using HarbirBooks.Models;

namespace HarbirBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);

    }
}
