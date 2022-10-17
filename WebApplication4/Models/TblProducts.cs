using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace WebApplication4.Models
{
    public class ProductResult : CommonProperty
    {
        public ProductResult() { }

        public ProductResult(DataSet ds)
        {
            ProductList = new List<Product>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Product oProduct;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    oProduct = new Product(row);
                    ProductList.Add(oProduct);
                }
            }
        }

        public List<Product> ProductList { get; set; }
    }
    public class Product
    {
        public Product() { }

        public Product(DataRow row)
        {
            ProductId = Convert.ToInt32(row["ProductId"].ToString());
            CategoryId = Convert.ToInt32(row["CategoryId"].ToString());
            ProductName = row["ProductName"].ToString();
            ProductCode = row["ProductCode"].ToString();
            Price = Convert.ToDouble(row["Price"].ToString());
            Description = row["Description"].ToString();
            Rating = row["Rating"].ToString();
            ProductImage = row["ProductImageLink"].ToString();
            Color = row["Color"].ToString();
            Reviewes = row["Reviewes"].ToString();
            IsActive = Convert.ToBoolean(row["IsActive"].ToString());
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public string ProductImage { get; set; }
        public string Color { get; set; }
        public string Reviewes { get; set; }
        public bool IsActive { get; set; }
    }
}
