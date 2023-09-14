using Core.DTOs.Category;
using DataAccess.Abstract;
using DataAccess.Concrete.Dapper;
using DataAccess.Repository.Dapper.Abstract;
using DataAccess.Repository.Dapper.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DpDataAccessModule
    {
        public static void AddScopeDAL(this IServiceCollection services)
        {
            
            services.AddScoped<ICategoryDal, DpCategoryDal>();
            services.AddScoped<Context>();
        }
    }
}
