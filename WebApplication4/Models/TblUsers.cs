using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace WebApplication4.Models
{
    public class User : CommonProperty
    {
        public User() { }

        public User(DataSet set)
        {
            if (set != null && set.Tables.Count > 0 && set.Tables[0].Rows.Count > 0)
            {
                DataRow row = set.Tables[0].Rows[0];

                UserId = Convert.ToInt32(row["UserId"].ToString());
                UserName = row["UserName"].ToString();
                MobileNo = row["MobileNo"].ToString();
                EmailAddress = row["EmailAddress"].ToString();
            }
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
    }
}