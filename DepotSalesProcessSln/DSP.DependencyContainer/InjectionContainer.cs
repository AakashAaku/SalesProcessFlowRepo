using DSP.Core.Interfaces;
using DSP.Core.Services;
using DSP.Data.Repositories;
using DSP.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.DependencyContainer
{
    public class InjectionContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICustomersService, CustomerServices>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();
        }
    }
}
