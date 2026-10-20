using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QST.ECommerce.Application;
using QST.ECommerce.Domain.Catalogue;
using System.Net.NetworkInformation;

namespace QST.ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandSvc;

        public BrandController(IBrandService brandSvc) // brandSvc = new BrandService();
        {
            _brandSvc = brandSvc;
        }

        [HttpPost]
        public ActionResult AddBrand(Brand request)
        {
            var result = _brandSvc.AddBrand(request);
            return Ok(result);
        }

        [HttpGet]
        public ActionResult GetAllBrands()
        {
            var list = _brandSvc.GetAllBrands();
            return Ok(list);
        }



    }
}
