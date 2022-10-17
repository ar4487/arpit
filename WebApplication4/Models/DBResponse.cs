using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace WebApplication4.Models
{
    public class DBResponse : CommonProperty
    {
        public DataSet ds { get; set; }
    }
}