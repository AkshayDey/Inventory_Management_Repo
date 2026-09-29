using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class Transfer
{
    public long TransferId { get; set; }

    public long? TransferFrom { get; set; }

    public long? UserId { get; set; }

    public DateTime? DateTime { get; set; }

    public long? ProductId { get; set; }

    public long? TransferTo { get; set; }
}
