﻿using FluentValidation;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigureServices
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
