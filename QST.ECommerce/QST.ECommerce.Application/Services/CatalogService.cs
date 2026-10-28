using QST.ECommerce.Application.Contracts;
using QST.ECommerce.Domain.Catalogue;
using QST.ECommerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogRepository _catRepo;
        public CatalogService(ICatalogRepository catRepo) 
        {
            _catRepo = catRepo;
        }

        #region Department

        public int SaveDepartment(Department department)
        {

            int resutl = _catRepo.AddDepartment(department);
            return resutl;
            // Implement logic to save the department to the database
            // Return the ID of the saved department
            //throw new NotImplementedException();
        }
        public List<Department> GetAllDepartments()
        {
            var list = _catRepo.GetAllDepartments();
            return list;
            // Implement logic to retrieve all departments from the database
            //throw new NotImplementedException();
        }

        #endregion

        #region Category 

        public int ManageCageotry(Category cateogry, DBCommands dbCommand)
        {
            int result = _catRepo.AddCategory(cateogry);
            return result;
        }
        public Category GetCategoryById(int id)
        {
            return _catRepo.GetCategoryById(id);
        }
        public List<Category> GetAllCategories()
        {
            return _catRepo.GetAllCategories();
        }

        #endregion

        #region Brand

        public int AddBrand(Brand brand)
        {
            return _catRepo.AddBrand(brand);
        }
        public List<Brand> GetAllBrands()
        {
            return _catRepo.GetAllBrands();
        }

        #endregion

        #region Product


        public int SaveProduct(Product product)
        {
            return _catRepo.AddProduct(product);
        }

        // Contract Rule 2
        public List<Product> GetAllProducts()
        {
            return _catRepo.GetAllProducts();
        }

        #endregion

    }
}
