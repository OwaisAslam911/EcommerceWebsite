using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public string? Review1 { get; set; }
        public int? Product { get; set; }
        public int? Customer { get; set; }
        public int? Rating { get; set; }

        public virtual User? CustomerNavigation { get; set; }
        public virtual Product? ProductNavigation { get; set; }
    }
}
