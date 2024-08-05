using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int? Customer { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? OrderStatus { get; set; }

        public virtual User? CustomerNavigation { get; set; }
        public virtual OrderStatus? OrderStatusNavigation { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
