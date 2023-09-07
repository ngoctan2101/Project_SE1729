using System;
using System.Collections.Generic;

namespace Project_SE1729.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int? UserId { get; set; }
        public string? Pid { get; set; }
        public string? Content { get; set; }

        public virtual Product? PidNavigation { get; set; }
        public virtual User? User { get; set; }
    }
}
