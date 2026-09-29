using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class ModulePageInfo
{
    public long ModulePageId { get; set; }

    public long? ModuleId { get; set; }

    public string? PageName { get; set; }
}
