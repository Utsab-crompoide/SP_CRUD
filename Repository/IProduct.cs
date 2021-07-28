using SP_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_CRUD.Repository
{
     public interface IProduct
    {
        void InsertProduct(ProductVm product); // C

        IEnumerable<Product> GetProducts(); // R

        Product GetProductByProductId(int productId); // R

        void UpdateProduct(Product product); //U

        void DeleteProduct(int productId); //D
       
    }
}
