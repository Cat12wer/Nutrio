using Nutrio.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Nutrio.Application
{
    internal class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Реєстрація сервісів
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDiaryService, DiaryService>();
            // services.AddScoped<IProductService, ProductService>();

            // Реєстрація AutoMapper (якщо плануєш використовувати)
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Реєстрація FluentValidation
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
