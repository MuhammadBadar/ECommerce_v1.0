using QST.ECommerce.Domain.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application.Contracts
{
    public interface ICatalogRepository
    {
        #region Department
        int AddDepartment(Department dept);
        //int UpdateDapartment(Department dept);
        //int DeleteDepartment(int deptId);
        //Department GetDepartmentById(int deptId); 
        List<Department> GetAllDepartments();

        #endregion
        #region Category

        int AddCategory(Category category);
        int UpdateCategory(Category category);
        List<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);

        #endregion
        #region Brand

        int AddBrand(Brand brand);
        List<Brand> GetAllBrands();

        #endregion
        #region Product

        int AddProduct(Product product);
        //int UpdateProduct(Product product);
        //int DeleteProduct(int id);
        //Product GetProductById(int id);
        List<Product> GetAllProducts();


        #endregion
    }
}
