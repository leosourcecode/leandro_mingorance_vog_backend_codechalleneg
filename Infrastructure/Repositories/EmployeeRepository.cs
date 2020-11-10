using Application.Repositories;
using Core.Contracts.Domain;
using Infrastructure.Repositories.Context;

namespace Infrastructure.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApiContext context) : base(context) { }
    }
}
