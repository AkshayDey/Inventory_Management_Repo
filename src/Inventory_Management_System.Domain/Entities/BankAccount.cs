using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class BankAccount
{
    public long BankId { get; set; }

    public string? Type { get; set; }

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public string? AccHolderName { get; set; }

    public string? AccountNo { get; set; }

    public string? Description { get; set; }

    public string BankCode { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public long? WarehouseId { get; set; }
}
