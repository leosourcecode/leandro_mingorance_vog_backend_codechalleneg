using Core.Contracts.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
         : base(options)
        { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
