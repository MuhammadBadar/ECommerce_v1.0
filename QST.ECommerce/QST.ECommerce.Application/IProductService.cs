using QST.ECommerce.Domain.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application
{
    public interface IProductService //Contract (What to do ?)
    {
        // Contract Rule 1
        int SaveProduct(Product product);

        // Contract Rule 2
        List<Product> GetAllProducts();

        // What to do ?  Very very very much important - Interface  
        // How to Do ? Clas which implement that interface 
    }
}
