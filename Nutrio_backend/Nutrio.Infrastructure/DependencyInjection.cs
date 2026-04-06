using Microsoft.Extensions.DependencyInjection;
using Nutrio.Domain.Interfaces;
using Nutrio.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Nutrio.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            // 1. Налаштування PostgreSQL
            services.AddDbContext<NutrioDbContext>(options =>
                options.UseNpgsql(connectionString));

            // 2. Реєстрація репозиторіїв (Scoped - створюється на кожен HTTP-запит)
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IBodyMetrixRepository, BodyMetrixRepository>();
            services.AddScoped<IDayCounterRepository, DayCounterRepository>();

            // 3. Реєстрація Unit of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
