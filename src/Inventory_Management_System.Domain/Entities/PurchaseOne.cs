using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class PurchaseOne
{
    public long PurchaseId { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public decimal? BalanceForward { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? DueAmount { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? PaymentMethod { get; set; }

    public long? SupplierId { get; set; }

    public string? SupplierInvoiceNo { get; set; }

    public long? UserId { get; set; }

    public string? Remarks { get; set; }

    public long? WarehouseId { get; set; }

    public bool? IsCancel { get; set; }
}
