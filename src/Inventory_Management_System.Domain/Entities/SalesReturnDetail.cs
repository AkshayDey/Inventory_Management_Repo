using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class SalesReturnDetail
{
    public long SalesReturnDetailsId { get; set; }

    public decimal Amount { get; set; }

    public int Quantity { get; set; }

    public long SalesReturnId { get; set; }

    public int? ProductId { get; set; }

    public decimal? PricePerPiece { get; set; }
}
