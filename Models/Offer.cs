using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Offer
    {
        public int OfferId { get; set; }
        public string? Offer1 { get; set; }
        public int? OfferStatus { get; set; }
        public DateTime? OfferStartDate { get; set; }
        public DateTime? OfferEndDate { get; set; }

        public virtual Status? OfferStatusNavigation { get; set; }
    }
}
