using QST.ECommerce.Application.Contracts;
using QST.ECommerce.Domain.Catalogue;
using QST.ECommerce.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Infrastructure.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        private CatalogDbContext _dbContext;

        public CatalogRepository(CatalogDbContext dbContext) // Constructor Injection
        {
            _dbContext = dbContext;
        }

        #region Department
        public int AddDepartment(Department dept)
        {
            _dbContext.Add(dept);
            return _dbContext.SaveChanges(); //It saves data of Context into DB

        }
        public List<Department> GetAllDepartments()
        {
            var list = _dbContext.Departments.ToList();
            return list;
        }
        #endregion
        #region Catagory
        public int AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            int result = _dbContext.SaveChanges();
            return result;
        }
        public int UpdateCategory(Category category)
        {
            var catFromDB = GetCategoryById(category.Id); // it will fetch data from Database 
            catFromDB.CategoryName = category.CategoryName;
            catFromDB.Description = category.Description;
            int result = _dbContext.SaveChanges();
            return result;

        }
        public bool DeleteCategory(int categoryId)
        {
            var catFromDB = GetCategoryById(categoryId);
            if (catFromDB != null)
            {
                _dbContext.Categories.Remove(catFromDB);
                int result = _dbContext.SaveChanges();
                return result > 0;
            }
            return false;
        }

        public Category GetCategoryById(int categoryId)
        {
            var category = _dbContext.Categories.FirstOrDefault(c => c.Id == categoryId);
            return category;
        }

        public List<Category> GetAllCategories()
        {
            var list = _dbContext.Categories.ToList();
            return list;

        }



        #endregion
        #region Brand
        public int AddBrand(Brand brand)
        {
            _dbContext.Add(brand);
            int result = _dbContext.SaveChanges(); // It saves data of Context into DB

            return result;
        }
        public List<Brand> GetAllBrands()
        {
            var list = _dbContext.Brands.ToList();
            return list;
        }

        #endregion
        #region Product
        public int AddProduct(Product product)
        {
            _dbContext.Products.Add(product); // This line will save product into the Context Class
            int result = _dbContext.SaveChanges(); // It will save Product Into Database
            return result;
        }
        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }
        #endregion

    }
}
