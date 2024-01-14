using BlogProjectCF.DataAccessL.Contexts;
using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.DataAccessL.Repositories.Concrete
{
    public class ArticleRepository : GenericRepository<Article>
    {
        public ArticleRepository(AppSqlContext context) : base(context)
        {
        }
    }
}
