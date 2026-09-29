using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class Module
{
    public long ModuleId { get; set; }

    public string ModuleName { get; set; } = null!;

    public bool Status { get; set; }
}
