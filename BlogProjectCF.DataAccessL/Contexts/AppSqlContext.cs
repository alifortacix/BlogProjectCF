using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.DataAccessL.Contexts
{
    public class AppSqlContext : DbContext
    {
        public AppSqlContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
