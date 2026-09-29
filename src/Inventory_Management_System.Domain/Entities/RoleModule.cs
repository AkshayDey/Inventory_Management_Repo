using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class RoleModule
{
    public long RoleModuleId { get; set; }

    public long RoleId { get; set; }

    public long ModuleId { get; set; }
}
