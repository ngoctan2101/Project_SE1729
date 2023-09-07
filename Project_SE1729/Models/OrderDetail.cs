using System;
using System.Collections.Generic;

namespace Project_SE1729.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public string? PId { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? PIdNavigation { get; set; }
    }
}
