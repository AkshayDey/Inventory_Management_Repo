using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class SalesProductTwo
{
    public long SalesProductId { get; set; }

    public long? SalesId { get; set; }

    public long? ProductNameId { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public decimal? PricePerPiece { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? TotalAmount { get; set; }

    public long? WarehouseId { get; set; }
}
