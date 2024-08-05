using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string? UserRole1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
