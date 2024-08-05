using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Color
    {
        public Color()
        {
            Products = new HashSet<Product>();
        }

        public int ColorId { get; set; }
        public string? Color1 { get; set; }
        public int? ColorStatus { get; set; }

        public virtual Status? ColorStatusNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
