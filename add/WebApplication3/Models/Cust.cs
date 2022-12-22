using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Cust
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? IsActive { get; set; }
    }
}
