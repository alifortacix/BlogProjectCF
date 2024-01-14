using BlogProjectCF.DataAccessL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.BusinessL.Extensions
{
    public static class BusinessLayerCustomExtensions
    {
        public static IServiceCollection ServicesCollectionCustom(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppSqlContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConn")));
            return services;
        }
    }
}
