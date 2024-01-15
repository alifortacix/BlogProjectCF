using BlogProjectCF.DataAccessL.Contexts;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.DataAccessL.Repositories.Concrete
{
    public class CategoryRepository : GenericRepository<Category> , ICategoryRepository
    {
        public CategoryRepository(AppSqlContext context) : base(context)
        {
        }
    }
}
