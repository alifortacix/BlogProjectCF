using BlogProjectCF.DataAccessL.Contexts;
using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.DataAccessL.Repositories.Concrete
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(AppSqlContext context) : base(context)
        {
        }
    }
}
