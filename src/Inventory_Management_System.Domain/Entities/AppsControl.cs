using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class AppsControl
{
    public long AppsControlId { get; set; }

    public bool? NotificationOn { get; set; }

    public bool? NotifiactionOff { get; set; }

    public bool? ActiveAccount { get; set; }

    public bool? DeactiveAccount { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? NotificationMessage { get; set; }

    public DateOnly? PaymentNotificationShowDate { get; set; }

    public string? PaymentNotificationMessage { get; set; }
}
