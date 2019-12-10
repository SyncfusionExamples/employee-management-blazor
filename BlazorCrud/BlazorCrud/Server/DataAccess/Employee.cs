using System;
using System.Collections.Generic;

namespace BlazorCrud.Server.DataAccess
{
    public partial class Employee
    {
        public long EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public long PhoneNumber { get; set; }
    }
}
