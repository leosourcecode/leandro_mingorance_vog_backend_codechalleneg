using Core.Contracts.Domain;
using System.Collections.Generic;

namespace Application.Services
{
    public interface IDepartmentService
    {
        public IEnumerable<Department> GetAll();
    }
}
