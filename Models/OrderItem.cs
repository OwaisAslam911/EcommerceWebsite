﻿using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class OrderItem
    {
        public int OrderItemId { get; set; }
        public int? OrderId { get; set; }
        public int? Product { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? ProductNavigation { get; set; }
    }
}