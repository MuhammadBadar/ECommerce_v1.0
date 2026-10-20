using QST.ECommerce.Domain.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application
{
    public interface IBrandService
    {
        int AddBrand(Brand brand);
        List<Brand> GetAllBrands();
    }
}
