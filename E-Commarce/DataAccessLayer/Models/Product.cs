using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Product
    {

        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public string product_img_url { get; set; }
        public string description { get; set; }

        //[ForeignKey("")]
        public int category_id {get; set;}
        //[ForeignKey("")]
        public Product_Category category { get; set; }

        //[ForeignKey("")]
        public int inventory_id { get; set; }
        public Product_Inventory inventory { get; set; }
        
        
        public decimal price { get; set; }
        public int discount_id { get; set; }

        public Discount discount { get; set; }  
        




        [AllowNull]
        public DateTime created_at { get; set; }
        [AllowNull]
        public DateTime mofidied_at { get; set;}
        [AllowNull]
        public DateTime deleted_at { get; set;}


    }
}
