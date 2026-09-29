using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class CustomerTwo
{
    public long CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Code { get; set; }

    public string? Category { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Remarks { get; set; }

    public long? UserId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CustomerAddress { get; set; }

    public string? CustomerBankAccount { get; set; }

    public string? CustomerStatus { get; set; }

    public string? CustomerOwnerName { get; set; }

    public string? CustomerOwnerPhone { get; set; }

    public long? WarehouseId { get; set; }
}
