using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QST.ECommerce.Application;
using QST.ECommerce.Domain.Catalogue;

namespace QST.ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _prodSvc;

        public ProductController(IProductService prodSvc)
        {
            _prodSvc = prodSvc;
        }

        [HttpGet("GetAllProducts")]
        public ActionResult GetAllProducts()
        {
            // Get Products from Database

            var list = _prodSvc.GetAllProducts(); 
            // Write code to save data into Database

            return Ok(list);


            List<Product> products = new List<Product>();
            
            Product p = new Product();
            p.Id = 1;
            p.ProductName = "Laptop";
            p.UnitPrice = 30000;

            products.Add(p);

            p = new Product();
            p.Id = 2;
            p.ProductName = "Mobile";
            p.UnitPrice = 13000;
            products.Add(p);

            p = new Product();
            p.Id = 3;
            p.ProductName = "Pefume";
            p.UnitPrice = 400;
            products.Add(p);

            return Ok(products);
        }

        [HttpPost]
        public ActionResult AddProduct(Product request)
        {

            //ProductService prodSvc = new ProductService();

            //ProductService prodSvc = new ProductService();
            _prodSvc.SaveProduct(request);
            // Write code to save data into Database

            return Ok("Product is Added Successfully");
        }
    }
}
