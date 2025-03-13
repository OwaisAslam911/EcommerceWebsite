using System;
using System.Collections.Generic;

namespace EcommerceWebsite.Models
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public string? SenderName { get; set; }
        public string? Email { get; set; }
        public string? Message1 { get; set; }
    }
}
