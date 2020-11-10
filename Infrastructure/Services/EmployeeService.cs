using Application.Services;
using Core.Contracts.Domain;
using System.Collections.Generic;

namespace Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        /// <summary>
        /// Get all Employees
        /// </summary>
        /// <returns>All Employees</returns>
        public IEnumerable<Employee> GetAll()
        {
            return BuildEmployees();
        }

        /// <summary>
        /// Get all Employees
        /// </summary>
        /// <returns>A list with the Employees</returns>
        public IList<Employee> ListAll()
        {
            return BuildEmployees();
        }

        private IList<Employee> BuildEmployees()
        {
            var employees = new List<Employee>();

            var employee = new Employee();
            employee.FirstName = "Logan";
            employee.LastName = "Smith";
            employee.JobTitle = "Executive Assistant";
            employees.Add(employee);

            employee.FirstName = "Ethan";
            employee.LastName = "Brown";
            employee.JobTitle = "Software Engineer";
            employees.Add(employee);

            employee.FirstName = "Sophia";
            employee.LastName = "Martin";
            employee.JobTitle = "Sales Manager";
            employees.Add(employee);

            return employees;
        }
    }
}
