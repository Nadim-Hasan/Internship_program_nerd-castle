using OnlineShop.API.Models;

namespace OnlineShop.API.interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
    }
}
