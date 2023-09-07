using System;
using System.Collections.Generic;

namespace Project_SE1729.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Reviews = new HashSet<Review>();
        }

        public string ProductId { get; set; } = null!;
        public string? Name { get; set; }
        public string? Image { get; set; }
        public int? Quanlity { get; set; }
        public double? Price { get; set; }
        public int? Cid { get; set; }
        public string? Description { get; set; }

        public virtual Category? CidNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
