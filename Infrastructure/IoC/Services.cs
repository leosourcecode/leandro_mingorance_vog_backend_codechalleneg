using Application.Services;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

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
        }
    }
}
