using QST.ECommerce.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QST.ECommerce.Domain.Catalogue;
using QST.ECommerce.Application;


namespace QST.ECommerce.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private CatalogDbContext _catalogDbContext;

       
        public ProductRepository(CatalogDbContext catalogDbContext)
        {
            _catalogDbContext = catalogDbContext;
        }

        public int AddProduct(Product p)
        {
            // Code to save Product Into  Database
            _catalogDbContext.Products.Add(p); // This line will save product into the Context Class
            int result = _catalogDbContext.SaveChanges(); // It will save Product Into Database
            return result;
        }

        public List<Product> GetAllProducts()
        {
            return _catalogDbContext.Products.ToList();
        }
    }
}
