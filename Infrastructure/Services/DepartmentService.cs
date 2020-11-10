using Application.Services;
using Core.Contracts.Domain;
using System.Collections.Generic;

namespace Infrastructure.Services
{
    public class DepartmentService : IDepartmentService
    {
        /// <summary>
        /// Get all Departments
        /// </summary>
        /// <returns>A list with the Departments</returns>
        public IEnumerable<Department> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
