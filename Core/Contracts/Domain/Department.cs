using System.Collections.Generic;

namespace Core.Contracts.Domain
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
