using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_CRUD.Models
{
    public class ProductVm
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Product_Code { get; set; }
    }
}
