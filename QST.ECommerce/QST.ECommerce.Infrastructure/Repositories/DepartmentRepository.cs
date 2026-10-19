using QST.ECommerce.Application;
using QST.ECommerce.Domain.Catalogue;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QST.ECommerce.Infrastructure.DbContexts;

namespace QST.ECommerce.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private CatalogDbContext _dbContext;

        //Constructor Injection        
        public DepartmentRepository(CatalogDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }
        public int AddDepartment(Department dept)
        {
            _dbContext.Add(dept);
            return _dbContext.SaveChanges(); //It saves data of Context into DB

            //throw new NotImplementedException();
        }

        public List<Department> GetAllDepartments()
        {
            var list = _dbContext.Departments.ToList();
            return list;
        }
    }
}
