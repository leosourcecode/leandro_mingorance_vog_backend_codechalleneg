using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Core.Contracts.Domain;
using Microsoft.AspNetCore.Mvc;
using Application.Services;

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
    }
}
