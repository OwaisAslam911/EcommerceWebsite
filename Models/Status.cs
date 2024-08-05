using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Status
    {
        public Status()
        {
            Categories = new HashSet<Category>();
            Colors = new HashSet<Color>();
            Discounts = new HashSet<Discount>();
            Offers = new HashSet<Offer>();
            Products = new HashSet<Product>();
            Sizes = new HashSet<Size>();
            SubCategories = new HashSet<SubCategory>();
            Users = new HashSet<User>();
        }

        public int StatusId { get; set; }
        public string? Status1 { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Size> Sizes { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
