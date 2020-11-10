using Core.Contracts.Domain;
using System.Collections.Generic;

namespace Application.Services
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAll();
        public IList<Employee> ListAll();
    }
}
