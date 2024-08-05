using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string? SubCategoryName { get; set; }
        public int? Category { get; set; }
        public int? SubCategoryStatus { get; set; }

        public virtual Category? CategoryNavigation { get; set; }
        public virtual Status? SubCategoryStatusNavigation { get; set; }
    }
}
