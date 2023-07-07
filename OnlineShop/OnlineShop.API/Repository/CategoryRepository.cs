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
            throw new NotImplementedException();
        }
    }
}
