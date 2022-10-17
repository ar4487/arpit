using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CompanyECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private IConfiguration Configuration;
        private string connString;

        public CommonController(IConfiguration _configuration)
        {
            Configuration = _configuration;
            connString = Configuration.GetConnectionString("EComDb");
        }

        #region Validate User
        [HttpPost]
        [Route("ValidateUser")]
        public User ValidateUser(string LoginId, string Password)
        {
            User oUser = new User();

            SqlParameter param1 = new SqlParameter("@LOGINID", LoginId) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@PASSWORD", Password) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param4 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_VALIDATEUSER", param1, param2, param3, param4);

            if (response != null)
            {
                oUser = new User(response.ds);
                oUser.IsSuccess = response.IsSuccess;
                oUser.Message = response.Message;
            }
            return oUser;
        }
        #endregion

        #region Category
        [HttpPost]
        [Route("FetchCategoryList")]
        public CategoryResult FetchCategoryList(string FilterCategoryCode)
        {
            CategoryResult oCategoryResult = new CategoryResult();

            SqlParameter param1 = new SqlParameter("@CATEGORYCODE", string.IsNullOrEmpty(FilterCategoryCode) ? "" : FilterCategoryCode) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param3 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_FetchCategoryList", param1, param2, param3);

            if (response != null)
            {
                oCategoryResult = new CategoryResult(response.ds);
                oCategoryResult.IsSuccess = response.IsSuccess;
                oCategoryResult.Message = response.Message;
            }
            return oCategoryResult;
        }
        [HttpPost]
        [Route("AddCategory")]
        public CategoryResult AddCategory(Category oCategory, int UserId)
        {
            CategoryResult oCategoryResult = new CategoryResult();

            SqlParameter param1 = new SqlParameter("@CATEGORYNAME", oCategory.CategoryName) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@CATEGORYCODE", oCategory.CategoryCode) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@USERID", UserId) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param5 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_AddCategory", param1, param2, param3, param4, param5);

            if (response != null)
            {
                oCategoryResult = new CategoryResult(response.ds);
                oCategoryResult.IsSuccess = response.IsSuccess;
                oCategoryResult.Message = response.Message;
            }
            return oCategoryResult;
        }
        [HttpPost]
        [Route("UpdateCategory")]
        public CategoryResult UpdateCategory(Category oCategory, int UserId)
        {
            CategoryResult oCategoryResult = new CategoryResult();

            SqlParameter param1 = new SqlParameter("@CATEGORYID", oCategory.CategoryId) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@CATEGORYNAME", oCategory.CategoryName) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@CATEGORYCODE", oCategory.CategoryCode) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@USERID", UserId) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param5 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param6 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_UpdateCategory", param1, param2, param3, param4, param5, param6);

            if (response != null)
            {
                oCategoryResult = new CategoryResult(response.ds);
                oCategoryResult.IsSuccess = response.IsSuccess;
                oCategoryResult.Message = response.Message;
            }
            return oCategoryResult;
        }
        [HttpPost]
        [Route("RemoveCategory")]
        public CategoryResult RemoveCategory(Category oCategory, int UserId)
        {
            CategoryResult oCategoryResult = new CategoryResult();

            SqlParameter param1 = new SqlParameter("@CATEGORYID", oCategory.CategoryId) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@USERID", UserId) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param4 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_RemoveCategory", param1, param2, param3, param4);

            if (response != null)
            {
                oCategoryResult = new CategoryResult(response.ds);
                oCategoryResult.IsSuccess = response.IsSuccess;
                oCategoryResult.Message = response.Message;
            }
            return oCategoryResult;
        }
        [HttpPost]
        [Route("ReAddCategory")]
        public CategoryResult ReAddCategory(Category oCategory, int UserId)
        {
            CategoryResult oCategoryResult = new CategoryResult();

            SqlParameter param1 = new SqlParameter("@CATEGORYID", oCategory.CategoryId) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@USERID", UserId) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param4 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_ReAddCategory", param1, param2, param3, param4);

            if (response != null)
            {
                oCategoryResult = new CategoryResult(response.ds);
                oCategoryResult.IsSuccess = response.IsSuccess;
                oCategoryResult.Message = response.Message;
            }
            return oCategoryResult;
        }
        #endregion

        #region Product
        [HttpPost]
        [Route("FetchProductList")]
        public ProductResult FetchProductList(string FilterProductCode)
        {
            ProductResult oProductResult = new ProductResult();

            SqlParameter param1 = new SqlParameter("@PRODUCTCODE", FilterProductCode) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param3 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_FetchProductList", param1, param2, param3);

            if (response != null)
            {
                oProductResult = new ProductResult(response.ds);
                oProductResult.IsSuccess = response.IsSuccess;
                oProductResult.Message = response.Message;
            }
            return oProductResult;
        }
        [HttpPost]
        [Route("AddProduct")]
        public ProductResult AddProduct(Product oProduct, int UserId)
        {
            ProductResult oProductResult = new ProductResult();

            SqlParameter param1 = new SqlParameter("@PRODUCTNAME", oProduct.ProductName) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@PRODUCTCODE", oProduct.ProductCode) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@PRICE", oProduct.Price) { SqlDbType = SqlDbType.Float };
            SqlParameter param4 = new SqlParameter("@CATEGORYID", oProduct.CategoryId) { SqlDbType = SqlDbType.Int };
            SqlParameter param5 = new SqlParameter("@DESCRIPTION", oProduct.Description) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param6 = new SqlParameter("@RATING", oProduct.Rating) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param7 = new SqlParameter("@PRODUCTIMAGE", oProduct.ProductImage) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param8 = new SqlParameter("@COLOR", oProduct.Color) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param9 = new SqlParameter("@REVIEWES", oProduct.Reviewes) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param10 = new SqlParameter("@USERID", UserId) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param11 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param12 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_AddProduct", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12);

            if (response != null)
            {
                oProductResult = new ProductResult(response.ds);
                oProductResult.IsSuccess = response.IsSuccess;
                oProductResult.Message = response.Message;
            }
            return oProductResult;
        }
        [HttpPost]
        [Route("UpdateProduct")]
        public ProductResult UpdateProduct(Product oProduct, int UserId)
        {
            ProductResult oProductResult = new ProductResult();

            SqlParameter param1 = new SqlParameter("@PRODUCTID", oProduct.ProductId) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@PRODUCTNAME", oProduct.ProductName) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@PRODUCTCODE", oProduct.ProductCode) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@PRICE", oProduct.Price) { SqlDbType = SqlDbType.Float };
            SqlParameter param5 = new SqlParameter("@CATEGORYID", oProduct.CategoryId) { SqlDbType = SqlDbType.Int };
            SqlParameter param6 = new SqlParameter("@DESCRIPTION", oProduct.Description) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param7 = new SqlParameter("@RATING", oProduct.Rating) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param8 = new SqlParameter("@PRODUCTIMAGE", oProduct.ProductImage) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param9 = new SqlParameter("@COLOR", oProduct.Color) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param10 = new SqlParameter("@REVIEWES", oProduct.Reviewes) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param11 = new SqlParameter("@USERID", UserId) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param12 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param13 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_UpdateProduct", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);

            if (response != null)
            {
                oProductResult = new ProductResult(response.ds);
                oProductResult.IsSuccess = response.IsSuccess;
                oProductResult.Message = response.Message;
            }
            return oProductResult;
        }
        [HttpPost]
        [Route("RemoveProduct")]
        public ProductResult RemoveProduct(Product oProduct, int UserId)
        {
            ProductResult oProductResult = new ProductResult();

            SqlParameter param1 = new SqlParameter("@ProductID", oProduct.ProductId) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@USERID", UserId) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param4 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_RemoveProduct", param1, param2, param3, param4);

            if (response != null)
            {
                oProductResult = new ProductResult(response.ds);
                oProductResult.IsSuccess = response.IsSuccess;
                oProductResult.Message = response.Message;
            }
            return oProductResult;
        }
        [HttpPost]
        [Route("ReAddProduct")]
        public ProductResult ReAddProduct(Product oProduct, int UserId)
        {
            ProductResult oProductResult = new ProductResult();

            SqlParameter param1 = new SqlParameter("@ProductID", oProduct.ProductId) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@USERID", UserId) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@ISSUCCESS", SqlDbType.Bit, 1) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Bit };
            SqlParameter param4 = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output, SqlDbType = SqlDbType.NVarChar };

            DBResponse response = ExecuteProcedureReturnDataSet("SP_ReAddProduct", param1, param2, param3, param4);

            if (response != null)
            {
                oProductResult = new ProductResult(response.ds);
                oProductResult.IsSuccess = response.IsSuccess;
                oProductResult.Message = response.Message;
            }
            return oProductResult;
        }
        #endregion

        [HttpPost]
        [ApiExplorerSettings(IgnoreApi = true)]
        public DBResponse ExecuteProcedureReturnDataSet(string procName, params SqlParameter[] paramters)
        {
            DBResponse result = new DBResponse();
            using (var sqlConnection = new SqlConnection(connString))
            {
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = procName;
                    if (paramters != null)
                    {
                        command.Parameters.AddRange(paramters);
                    }
                    using (var da = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        if (sqlConnection.State == ConnectionState.Closed)
                            sqlConnection.Open();
                        da.Fill(ds);
                        if (sqlConnection.State == ConnectionState.Open)
                            sqlConnection.Close();

                        result.IsSuccess = ((command.Parameters["@ISSUCCESS"].Value).ToString() != "0") ? true : false;
                        result.Message = command.Parameters["@MESSAGE"].Value.ToString();

                        if (ds != null && ds.Tables.Count > 0)
                            result.ds = ds;

                    }
                }
            }
            return result;
        }
    }
}
