using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            Reviews = new HashSet<Review>();
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? ProfileName { get; set; }
        public string? ProfilePic { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhone { get; set; }
        public int? UserRole { get; set; }
        public string? UserPassword { get; set; }
        public int? UserStatus { get; set; }

        public virtual UserRole? UserRoleNavigation { get; set; }
        public virtual Status? UserStatusNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
