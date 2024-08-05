using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Size
    {
        public Size()
        {
            Products = new HashSet<Product>();
        }

        public int SizeId { get; set; }
        public string? Size1 { get; set; }
        public int? SizeStatus { get; set; }

        public virtual Status? SizeStatusNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
