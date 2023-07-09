using OnlineShop.API.interfaces;
using OnlineShop.API.Models;

namespace OnlineShop.API.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        OShopDbContext _dbContext;
        public CategoryRepository (OShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public CategoryRepository() {
        
        }
    
        public List<Category> GetAll()
        {
            //throw new NotImplementedException();

            //retrun _dbContext.Categories.Where(c=>!c.IsDelete).ToList();
            return _dbContext.Categories.Where(c=>!c.IsDeleted).ToList();
        }

        public Category GetCategory(int id)
        {
            
          return _dbContext.Categories.FirstOrDefault(c => c.Id == id && !c.IsDeleted);
            
        }

        public bool Add(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Edit(Category category)
        {
            var existingCategory = _dbContext.Categories.FirstOrDefault(c => c.Id == category.Id && !c.IsDeleted);

            if (existingCategory != null)
            {
                _dbContext.Categories.Update(category);
                return _dbContext.SaveChanges()>0;
                 
            }

            return false;
        }

        public bool Delete(int id)
        {
           var category = _dbContext.Categories.FirstOrDefault(c=>c.Id == id);
            if (category != null)
            {
                category.IsDeleted = true;
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }
    }
}
