using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get;private set; }
        public Status status { get; set; }
        public User user { get; set; }

        protected Order() { }

        public void MarkAsPaid()
        {
            status = Status.AwaitingShipment;
        }


    }
}
