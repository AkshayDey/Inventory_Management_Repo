using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class Note
{
    public long NoteId { get; set; }

    public long? SalesmanId { get; set; }

    public string? Note1 { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateOnly? Date { get; set; }
}
