using Dapper;
using SP_CRUD.DbConnection;
using SP_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SP_CRUD.Repository
{
    public class ProductConcrete : IProduct
    {
        public void DeleteProduct(int productId)
        {
            using var con = new SqlConnection(ShareConnectionString.Value);
            var param = new DynamicParameters();
            param.Add("@ProductId", productId);
            var result = con.Execute("Usp_Delete_Product", param, null, 0, CommandType.StoredProcedure);
           
        }

        public Product GetProductByProductId(int productId)
        {
            using var con = new SqlConnection(ShareConnectionString.Value);
            var param = new DynamicParameters();
            param.Add("@ProductId", productId);
            return con.Query<Product>("Usp_Get_Productby_ProductId", param, null, true, 0, CommandType.StoredProcedure).FirstOrDefault();
           
        }

        public IEnumerable<Product> GetProducts()
        {
            using var con = new SqlConnection(ShareConnectionString.Value);
            return con.Query<Product>("Usp_GetAll_Product", null, null, true, 0, CommandType.StoredProcedure).ToList();
            
        }

        public void InsertProduct(ProductVm product)
        {
            try
            {
                using var con = new SqlConnection(ShareConnectionString.Value);
                Console.WriteLine(ShareConnectionString.Value);
                con.Open();
                var transaction = con.BeginTransaction();
                try
                {
                    var param = new DynamicParameters();
                    param.Add("@Name", product.Name);
                    param.Add("@Quantity", product.Quantity);
                    param.Add("@Color", product.Color);
                    param.Add("@Price", product.Price);
                    param.Add("@ProductCode", product.Product_Code);
                    Console.WriteLine(product);
                    var result = con.Execute("Usp_Insert_Product", param, transaction, 0, CommandType.StoredProcedure);
                    Console.WriteLine(result);
                    if(result > 0)
                    {
                        transaction.Commit();
                    }

                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void UpdateProduct(Product product)
        {
            using var con = new SqlConnection(ShareConnectionString.Value);
            con.Open();
            var transaction = con.BeginTransaction();
            try
            {
                var param = new DynamicParameters();
                param.Add("@Name", product.Name);
                param.Add("@Quantity", product.Quantity);
                param.Add("@Color", product.Color);
                param.Add("@Price", product.Price);
                param.Add("@ProductCode", product.Product_Code);
                param.Add("@ProductId", product.ProductId);
                var result = con.Execute("Usp_Update_Product", param, transaction, 0, CommandType.StoredProcedure);
                if (result > 0)
                {
                    transaction.Commit();
                }
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            
        }
        

        
    }
}
