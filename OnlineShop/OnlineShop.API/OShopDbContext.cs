using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Models;

namespace OnlineShop.API
{
    public class OShopDbContext:DbContext
    {
        public OShopDbContext (DbContextOptions<OShopDbContext> options): base(options) { }

        public DbSet<Category> Categories { get; set; }
    }
}
