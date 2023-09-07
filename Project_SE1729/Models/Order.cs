using System;
using System.Collections.Generic;

namespace Project_SE1729.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? UId { get; set; }
        public double? TotalMoney { get; set; }
        public DateTime? Date { get; set; }

        public virtual User? UIdNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
