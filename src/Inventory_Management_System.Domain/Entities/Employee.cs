using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Remarks { get; set; }

    public long? WarehouseId { get; set; }

    public decimal? Salary { get; set; }

    public string? EmployeeType { get; set; }

    public string? UserId { get; set; }
}
