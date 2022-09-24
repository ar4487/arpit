using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Customercode { get; set; }
        public string Customername { get; set; }
        public string CustomerAmount { get; set; }
    }
}
