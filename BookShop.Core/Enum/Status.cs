using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Core.Models
{
    public enum Status
    {
        Pending,
        AwaitingPayment,
        AwaitingShipment,
        AwaitingPickup,
        Completed,
        Shipped,
        Cancelled,
        Declined
    }
}
