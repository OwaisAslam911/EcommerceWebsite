using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            OrderItems = new HashSet<OrderItem>();
            Reviews = new HashSet<Review>();
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductImage { get; set; }
        public decimal? Price { get; set; }
        public string? ProductDescription { get; set; }
        public int? ProductQuantity { get; set; }
        public int? ProductStatus { get; set; }
        public int? ProductColor { get; set; }
        public int? ProductSize { get; set; }

        public virtual Color? ProductColorNavigation { get; set; }
        public virtual Size? ProductSizeNavigation { get; set; }
        public virtual Status? ProductStatusNavigation { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
