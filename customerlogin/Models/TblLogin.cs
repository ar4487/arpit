using System;
using System.Collections.Generic;

#nullable disable

namespace customerlogin.Models
{
    public partial class TblLogin
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Isactive { get; set; }
    }
}
