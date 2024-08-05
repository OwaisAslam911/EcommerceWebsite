using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; } = null!;
        public string DiscountType { get; set; } = null!;
        public decimal DiscountValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? DiscountStatus { get; set; }

        public virtual Status? DiscountStatusNavigation { get; set; }
    }
}
