using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class LoanSector
{
    public long LoanSectorId { get; set; }

    public string? SectorName { get; set; }

    public long? WarehouseId { get; set; }
}
