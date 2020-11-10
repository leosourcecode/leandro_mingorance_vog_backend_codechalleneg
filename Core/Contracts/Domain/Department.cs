using System.Collections.Generic;

namespace Core.Contracts.Domain
{
    public class Department
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
