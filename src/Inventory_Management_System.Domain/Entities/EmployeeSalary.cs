using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class EmployeeSalary
{
    public long EmployeeSalaryId { get; set; }

    public long? EmployeeId { get; set; }

    public decimal? Amount { get; set; }

    public DateOnly? Date { get; set; }

    public string? Remarks { get; set; }

    public string? PaymentMethod { get; set; }

    public long? WarehouseId { get; set; }

    public DateTime? EntryDate { get; set; }
}
