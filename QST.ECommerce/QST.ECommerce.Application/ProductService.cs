using QST.ECommerce.Domain.Catalogue;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository prodRepo)
        {
            _productRepository = prodRepo;
        }

        public int SaveProduct(Product product)
        {
            // Need to apply Business Rules - Use Case Relevant

            // Business Rules 
            if (string.IsNullOrWhiteSpace(product.ProductName))
            {
                return -1;
            }
            if (product.UnitPrice <= 0)
            {
                return -1;
            }

            // Write code to pass this data to Infrastructure Layer
            _productRepository.AddProduct(product);

            return product.Id;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();

        }
    }
}
