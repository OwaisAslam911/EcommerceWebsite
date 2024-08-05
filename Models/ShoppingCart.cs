using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class ShoppingCart
    {
        public ShoppingCart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int CartId { get; set; }
        public int? CartUser { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual User? CartUserNavigation { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
