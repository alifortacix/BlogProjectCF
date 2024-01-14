using BlogProjectCF.DataAccessL.Contexts;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.DataAccessL.Repositories.Concrete
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository(AppSqlContext context) : base(context)
        {
        }
    }
}
