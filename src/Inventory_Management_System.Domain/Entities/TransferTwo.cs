using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class TransferTwo
{
    public long TransferId { get; set; }

    public long FromTransferId { get; set; }

    public long? ToTransferId { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public decimal? ExtraAmount { get; set; }

    public string? FromTransferHead { get; set; }

    public string? ToTransferHead { get; set; }

    public DateOnly? Date { get; set; }
}
