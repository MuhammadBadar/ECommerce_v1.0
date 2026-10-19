using QST.ECommerce.Domain.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application
{
    public interface IProductRepository //Contract
    {
        // Contract Rules
        int AddProduct(Product product);
        //int UpdateProduct(Product product);
        //int DeleteProduct(int id);
        //Product GetProductById(int id); 
        List<Product> GetAllProducts();

    }
}
