using HarbirBooks.DataAccess.Repository.IRepository;
using HarbirBookStore.DataAccess.Data;

namespace HarbirBooks.DataAccess.Repository
{
    internal class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext db;

        public CategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
    }
}