using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using ServicesArticles;

namespace HomeWork_2
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IA, A>();
            services.AddSingleton<IB, B>();
            services.AddTransient<IC, C>();
            services.AddScoped<ID, D>();
            services.AddScoped<IE, E>();


            return services;
        }
    }
}