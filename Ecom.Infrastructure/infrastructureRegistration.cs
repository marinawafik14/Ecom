using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Repositires;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ecom.Infrastructure
{
    public static  class infrastructureRegistration
    {
        public static IServiceCollection infrastructureConfiguration( this IServiceCollection service)
        {
            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddScoped<ICategoryRepository, CategoryRepository>();
            return service;

        }



    }
}
