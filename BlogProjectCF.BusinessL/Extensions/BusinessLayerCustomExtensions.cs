using BlogProjectCF.BusinessL.Managers.Abstract;
using BlogProjectCF.BusinessL.Managers.Concrete;
using BlogProjectCF.DataAccessL.Contexts;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.DataAccessL.Repositories.Concrete;
using BlogProjectCF.EntityL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using System.Reflection;

namespace BlogProjectCF.BusinessL.Extensions
{
    public static class BusinessLayerCustomExtensions
    {
        public static IServiceCollection ServicesCollectionCustom(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<AppSqlContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConn")));
            services.AddDbContext<AppSqlContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConn")), ServiceLifetime.Scoped);


            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IAuthorManager, AuthorManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IArticleManager, ArticleManager>();

            services.AddAutoMapper(typeof(BusinessLayerCustomExtensions));

            AssemblyScanner.FindValidatorsInAssembly(Assembly.GetExecutingAssembly())
            .ForEach(item => services.AddScoped(item.InterfaceType, item.ValidatorType));

            return services;
        }
    }
}
