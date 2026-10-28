using QST.ECommerce.Domain.Catalogue;
using QST.ECommerce.Domain.Enums;

namespace QST.ECommerce.Application.Contracts
{
    public interface ICatalogService
    {
        #region Department

        int SaveDepartment(Department department);
        List<Department> GetAllDepartments();

        #endregion

        #region Category 

        int ManageCageotry(Category cateogry, DBCommands dbCommand); // Insert, Update and Delete opertaions
        Category GetCategoryById(int id);
        List<Category> GetAllCategories();

        #endregion

        #region Brand

        int AddBrand(Brand brand);
        List<Brand> GetAllBrands();

        #endregion

        #region Product


        int SaveProduct(Product product);

        // Contract Rule 2
        List<Product> GetAllProducts();

        #endregion

    }
}
