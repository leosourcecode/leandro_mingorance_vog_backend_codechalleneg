using Application.Repositories;
using Application.Services;
using Core.Contracts.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Get all Employees
        /// </summary>
        /// <returns>All Employees</returns>
        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        /// <summary>
        /// Get all Employees
        /// </summary>
        /// <returns>A list with the Employees</returns>
        public IList<Employee> ListAll()
        {
            return _employeeRepository.GetAll().ToList();
        }
    }
}
