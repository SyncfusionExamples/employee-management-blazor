using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrud.Server.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrud.Server.Controllers
{
    public class EmployeeController : ControllerBase
    {
        IEmployeAccessLayer _employee;

        public EmployeeController(IEmployeAccessLayer employee)
        {
            _employee = employee;
        }

        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<Employee> Index()
        {
            return _employee.GetAllEmployees();
        }

        [HttpPost]
        [Route("api/Employee/Create")]
        public void Create([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
                this._employee.AddEmployee(employee);
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public Employee Details(int id)
        {
            return _employee.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public void Edit([FromBody]Employee employee)
        {
            if (ModelState.IsValid)
                this._employee.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public void Delete(int id)
        {
            _employee.DeleteEmployee(id);
        }
    }
}