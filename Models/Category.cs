using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? CategoryStatus { get; set; }

        public virtual Status? CategoryStatusNavigation { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
