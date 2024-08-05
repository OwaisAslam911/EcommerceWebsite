using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class CartItem
    {
        public int CartItemId { get; set; }
        public int? Cart { get; set; }
        public int? CartProduct { get; set; }
        public int Quantity { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual ShoppingCart? CartNavigation { get; set; }
        public virtual Product? CartProductNavigation { get; set; }
    }
}
