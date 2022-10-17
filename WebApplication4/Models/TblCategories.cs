using System;
using System.Collections.Generic;
using System.Data;

namespace WebApplication4.Models
{
    public class CategoryResult : CommonProperty
    {
        public CategoryResult() { }

        public CategoryResult(DataSet ds)
        {
            CategoryList = new List<Category>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Category oCategory;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    oCategory = new Category(row);
                    CategoryList.Add(oCategory);
                }
            }
        }

        public List<Category> CategoryList { get; set; }
    }
    public class Category
    {
        public Category() { }

        public Category(DataRow row)
        {
            CategoryId = Convert.ToInt32(row["CategoryId"].ToString());
            CategoryName = row["CategoryName"].ToString();
            CategoryCode = row["CategoryCode"].ToString();
            IsActive = Convert.ToBoolean(row["IsActive"].ToString());
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public int ProductCount { get; set; }
        public bool IsActive { get; set; }
    }
}