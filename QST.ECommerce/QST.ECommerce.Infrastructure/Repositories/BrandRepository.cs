using QST.ECommerce.Application;
using QST.ECommerce.Domain.Catalogue;
using QST.ECommerce.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly CatalogDbContext _dbContext;
        public BrandRepository(CatalogDbContext dbContext)  // this line will initialize the dbContext variable with the instance of CatalogDbContext that is passed in as a parameter
        { 
            _dbContext = dbContext;
        }
        public int AddBrand(Brand brand)
        {
            _dbContext.Add(brand);
            int result = _dbContext.SaveChanges(); // It saves data of Context into DB
            
            return result; 
            //throw new NotImplementedException();
        }

        public List<Brand> GetAllBrands()
        {
            //throw new NotImplementedException();
            var list = _dbContext.Brands.ToList();
            return list;
        }
    }
}
