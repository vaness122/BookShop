using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Core.Models
{
   public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string Username { get;private set; }
        public string PasswordHash { get; private set; }
        public UserRole Role { get;private set; }

        public User(int id , string username, string passwordHash, UserRole role)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required", nameof(username));
            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new ArgumentException("Password is required", nameof(passwordHash));

            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            Role = role;
        }
    }
}
