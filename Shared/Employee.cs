using System;
using System.Collections.Generic;

namespace BlazorCrud.Server.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public string? Email { get; set; }

    public string? Location { get; set; }

    public int? PhoneNumber { get; set; }
}
