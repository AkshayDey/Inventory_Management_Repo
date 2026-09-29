using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class OrderDetail
{
    public long OrderDetailsId { get; set; }

    public long? OrderId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public long? ProductId { get; set; }

    public decimal? NewQuantity { get; set; }

    public decimal? NewUnitPrice { get; set; }

    public decimal? NewTotalPrice { get; set; }

    public decimal? FreeItem { get; set; }
}
