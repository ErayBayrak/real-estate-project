using Business.Abstract;
using Business.Concrete;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class DpBusinessModule
    {
        public static void AddScopeBL(this IServiceCollection services)
        {
            services.AddScopeDAL();
            services.AddScoped<ICategoryService,CategoryManager>();
            
        }
    }
}
