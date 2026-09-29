using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class OrderInfoOne
{
    public long OrderId { get; set; }

    public long? CustomerId { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? DueAmount { get; set; }

    public string? PaymentMethod { get; set; }

    public long? SalesmanId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public bool? IsCancel { get; set; }

    public bool? IsPaid { get; set; }

    public string? Remarks { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? EntryDate { get; set; }

    public long? WarehouseId { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public decimal? BalanceForward { get; set; }

    public bool? IsApproved { get; set; }

    public decimal? NewTotalAmount { get; set; }

    public decimal? NewNetAmount { get; set; }

    public bool? IsApproved2 { get; set; }

    public long? MangerId { get; set; }

    public long? AdminId { get; set; }

    public string? PaymentStatus { get; set; }
}
