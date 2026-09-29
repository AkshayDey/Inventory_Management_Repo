using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class SupplierPaymentTwo
{
    public long SupplierPaymentId { get; set; }

    public string? InvoiceNo { get; set; }

    public long? SupplierId { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public decimal? OpeningBalance { get; set; }

    public decimal? PurchaseAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? ClosingBalance { get; set; }

    public string? Remarks { get; set; }

    public string? PaymentMethod { get; set; }

    public long? WarehouseId { get; set; }
}
