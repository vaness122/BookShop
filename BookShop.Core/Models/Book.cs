using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Core.Models
{
   public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; private set; }
        public Category Category { get; set; }

        public Book(int id, string title, decimal price, Category category)
        {
            Id = id;
            Title = title;
            Price = price;
            Category = category;
        }


        public void DecreaseStuck(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive", nameof(amount));
            if (amount > Stock) throw new InvalidOperationException("Not enough stock");
            Stock -= amount;    

        }

        public void ChangeCategory(Category newCategory)
        {
            if (newCategory == null) throw new ArgumentNullException("Category is empty");
            Category = newCategory; //encapsulated update
        }

        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice <= 0)
                throw new ArgumentException("Price must be positive", nameof(newPrice));
            Price = newPrice;
        }
    }
}



