using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class SupplierTwo
{
    public long SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? Code { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactPersonPhone { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public bool? Status { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? UserId { get; set; }

    public string? BankAccount { get; set; }

    public string? BankAccountDetails { get; set; }

    public long? WarehouseId { get; set; }
}
