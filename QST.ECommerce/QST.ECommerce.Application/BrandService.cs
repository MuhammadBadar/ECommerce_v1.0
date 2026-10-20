using QST.ECommerce.Domain.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository) // It intilizes the _brandRepository field with the provided IBrandRepository instance.
        {
            _brandRepository = brandRepository;
        }
        public int AddBrand(Brand brand)
        {
            int result = _brandRepository.AddBrand(brand);
            return result;
            //throw new NotImplementedException();

        }

        public List<Brand> GetAllBrands()
        {
            var brands = _brandRepository.GetAllBrands();
            return brands;
            //throw new NotImplementedException();
        }
    }
}
