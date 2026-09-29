using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class ExpenseSector
{
    public long ExpenseSectorId { get; set; }

    public string? ExpenseSectorName { get; set; }

    public long? WarehouseId { get; set; }
}
