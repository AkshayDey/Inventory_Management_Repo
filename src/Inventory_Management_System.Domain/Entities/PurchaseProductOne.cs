using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class PurchaseProductOne
{
    public long PurchaseProductTableId { get; set; }

    public long PurchaseId { get; set; }

    public long ProductId { get; set; }

    public decimal PricePerPiece { get; set; }

    public decimal Quantity { get; set; }

    public decimal TotalAmount { get; set; }

    public long? WarehouseId { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public decimal? SellingPrice { get; set; }

    public string? SecretCode { get; set; }
}
