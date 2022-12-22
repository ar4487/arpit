using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Pro
    {
        public int ProductId { get; set; }
        public int? Id { get; set; }
        public int? ProductSku { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int? IsActive { get; set; }
    }
}
