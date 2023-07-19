using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext()
        {
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=.;Database=E-CommerceDb;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }
    


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart_Items>Cart_Items { get; set; }
        public DbSet<Discount>Discounts { get; set; }
        public DbSet<Order_Details>Order_Details { get; set; }
        public DbSet<Order_Items>Order_Items{ get; set; }
        public DbSet<Payment_Details>Payment_Details{ get; set; }
        public DbSet<Product_Category>Product_Categories{ get; set; }
        public DbSet<Product_Inventory>Product_Inventoru { get; set; }

        public DbSet<Shopping_Session> Shopping_sessions { get; set; }


//public DbSet<Order>Orders { get; set; }
// public DbSet<ProductOrder>ProductOrders { get; set; }

     


    }
}
