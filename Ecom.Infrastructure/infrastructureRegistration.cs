using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using Ecom.Infrastructure.Repositires;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Ecom.Infrastructure
{
    public static  class infrastructureRegistration
    {
        public static IServiceCollection infrastructureConfiguration( this IServiceCollection service , IConfiguration configuration)
        {
            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //service.AddScoped<ICategoryRepository, CategoryRepository>();
            //service.AddScoped<IProductRepository, ProductRepository>();
            //service.AddScoped<IPhotoRepository, PhotoRepository>();
            service.AddScoped<IUnitOfWork, IUnitOfWork>();
            service.AddDbContext<AppDbContext>( op =>
            {
                op.UseSqlServer(configuration.GetConnectionString("EcomDatabase"));
            });
            return service;

        }



    }
}
