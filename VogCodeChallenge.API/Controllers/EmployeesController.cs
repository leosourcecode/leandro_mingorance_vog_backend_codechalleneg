using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Core.Contracts.Domain;
using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Infrastructure.Repositories.Context;
using System.Linq;

namespace VogCodeChallenge.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IServiceProvider _services;

        public EmployeesController(IServiceProvider services)
        {
            _services = services;
            BuildData(_services.GetService<ApiContext>());
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _services.GetService<IEmployeeService>().GetAll();
        }

        [HttpGet("department/{departmentId}")]
        public IEnumerable<Employee> Get(int departmentId)
        {
            throw new System.NotImplementedException();
        }

        private void BuildData(ApiContext context)
        {
            var address = new Address
            {
                Id = 1,
                FullAddress = "1"
            };
            context.Address.Add(address);

            var address2 = new Address
            {
                Id = 2,
                FullAddress = "2"
            };
            context.Address.Add(address2);

            context.SaveChanges();

            var employee = new Employee
            {
                FirstName = "Logan",
                LastName = "Smith",
                JobTitle = "Executive Assistant",
                Address = context.Address.Where(a => a.Id == 1).FirstOrDefault()
            };
            context.Employees.Add(employee);

            var employee2 = new Employee
            {
                FirstName = "Ethan",
                LastName = "Brown",
                JobTitle = "Software Engineer"
            };
            context.Employees.Add(employee2);

            context.SaveChanges();

            var employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(employee2);

            var department = new Department
            {
                Id = 1,
                Name = "IT",
                Address = context.Address.Where(a => a.Id == 2).FirstOrDefault(),
                Employees = context.Employees.ToList()
            };
            context.Departments.Add(department);

            context.SaveChanges();
        }
    }
}
