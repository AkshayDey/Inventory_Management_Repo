using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class StoreTwo
{
    public long StoreId { get; set; }

    public long? ProductNameId { get; set; }

    public decimal? AvgUnitPrice { get; set; }

    public decimal? TotalAmount { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public long? WarehouseId { get; set; }
}
