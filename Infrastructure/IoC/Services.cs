using Application.Repositories;
using Application.Services;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Context;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure.IoC
{
    /// <summary>
    /// IoC Setup
    /// </summary>
    public class Services
    {
        /// <summary>
        /// Configure dependency injection
        /// </summary>
        /// <param name="services"></param>
        public void Configure(IServiceCollection services)
        {
            // Services
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IEmployeeService, EmployeeService>();

            // Repositories
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            // Context
            services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()), ServiceLifetime.Scoped, ServiceLifetime.Scoped);
        }
    }
}
