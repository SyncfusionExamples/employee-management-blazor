using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.DataAccess
{
    public interface IEmployeAccessLayer
    {
        IEnumerable<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        Employee GetEmployeeData(long id);
        void DeleteEmployee(long id);
    }

    public class EmployeAccessLayer : IEmployeAccessLayer
    {
        private BlazorContext _context;
        public EmployeAccessLayer(BlazorContext context)
        {
            _context = context;
        }

        //To Get all employees details   
        public IEnumerable<Employee> GetAllEmployees()
        {
            try
            {
                return _context.Employee.ToList();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        //To Add new employee record     
        public void AddEmployee(Employee employee)
        {
            try
            {
                _context.Employee.Add(employee);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public void UpdateEmployee(Employee employee)
        {
            try
            {
                _context.Entry(employee).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee    
        public Employee GetEmployeeData(long id)
        {
            try
            {
                Employee employee = _context.Employee.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee    
        public void DeleteEmployee(long id)
        {
            try
            {
                Employee emp = _context.Employee.Find(id);
                _context.Employee.Remove(emp);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
