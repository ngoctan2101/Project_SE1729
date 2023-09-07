using System;
using System.Collections.Generic;

namespace Project_SE1729.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            Reviews = new HashSet<Review>();
        }

        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string Gmail { get; set; } = null!;
        public int? Role { get; set; }
        public string? Address { get; set; }
        public int? Gender { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
