using QST.ECommerce.Application;
using QST.ECommerce.Domain.Catalogue;
using QST.ECommerce.Infrastructure.DbContexts;

namespace QST.ECommerce.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CatalogDbContext _catalogDbContext;
        public CategoryRepository(CatalogDbContext catalogDbContext) // Initialization through Construction Injection 
        {
            // catalogDbContext = new CatalogDbContext(); 
            _catalogDbContext = catalogDbContext;
        }
        public int AddCategory(Category category)
        {
            _catalogDbContext.Categories.Add(category);
            int result = _catalogDbContext.SaveChanges();
            return result;

            //throw new NotImplementedException();
        }

        public int UpdateCategory(Category category)
        {
            var catFromDB = GetCategoryById(category.Id); // it will fetch data from Database 
            catFromDB.CategoryName = category.CategoryName;
            catFromDB.Description = category.Description;
            int result = _catalogDbContext.SaveChanges();
            return result;
            //throw new NotImplementedException();
        }

        public bool DeleteCategory(int categoryId)
        {
            var catFromDB = GetCategoryById(categoryId);
            if (catFromDB != null)
            {
                _catalogDbContext.Categories.Remove(catFromDB);
                int result = _catalogDbContext.SaveChanges();
                return result > 0;
            }
            return false;
        }

        public Category GetCategoryById(int categoryId)
        {
            var category = _catalogDbContext.Categories.FirstOrDefault(c => c.Id == categoryId);
            return category;
            //throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            var list = _catalogDbContext.Categories.ToList();
            return list;
            //throw new NotImplementedException();
        }

        

        
    }
}
