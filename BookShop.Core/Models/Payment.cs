using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Core.Models
{
   public class Payment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public decimal Amount { get; private set; }
        public DateTime PaidAt { get; private set; }


        protected Payment() { }

        public Payment(User user , decimal amount)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));

            if (amount <= 0)
                throw new ArgumentException("Payment amount must be positive", nameof(amount));

            Amount = amount;
            PaidAt = DateTime.UtcNow;
        }
    }
}
