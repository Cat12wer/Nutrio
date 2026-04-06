using Microsoft.Extensions.DependencyInjection;
using Nutrio.Application.Interfaces;
using Nutrio.Application.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Nutrio.Application
{
    public static class ApplicationRegistration
    {
     
        
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            // Додайте реєстрацію нового сервісу тут
            services.AddScoped<IBodyMetrixService, BodyMetrixService>();


            return services;
        }
    }
}
