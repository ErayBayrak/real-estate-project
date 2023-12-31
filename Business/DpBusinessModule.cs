﻿using Business.Abstract;
using Business.Concrete;
using Business.Repository.Dapper.Abstract;
using Business.Repository.Dapper.Concrete;
using Core.DTOs.Category;
using DataAccess;
using DataAccess.Repository.Dapper.Abstract;
using DataAccess.Repository.Dapper.Concrete;
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
            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<IWhoWeAreDetailService,WhoWeAreDetailManager>();
            services.AddScoped<IServiceService,ServiceManager>();
            services.AddScoped<IBottomGridService,BottomGridManager>();
            services.AddScoped<IPopularLocationService,PopularLocationManager>();
            services.AddScoped<ITestimonialService,TestimonialManager>();
        }
    }
}
