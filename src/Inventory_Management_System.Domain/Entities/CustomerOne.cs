using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class CustomerOne
{
    public long CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? Code { get; set; }

    public string Category { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public long? UserId { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? CustomerAddress { get; set; }

    public string? CustomerBankAccount { get; set; }

    public string? CustomerStatus { get; set; }

    public string? CustomerOwnerName { get; set; }

    public string? CustomerOwnerPhone { get; set; }

    public long? WarehouseId { get; set; }
}
