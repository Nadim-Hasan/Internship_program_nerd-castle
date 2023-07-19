using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public  class Product_Category
    {

        [Key]
        public int id {  get; set; }    
        public string name { get; set; }

        public string cat_img_url { get; set; } 
        public string description { get; set; }


        public virtual ICollection<Product> products { get; set; }  = new List<Product>();


        [AllowNull]
        public DateTime created_at { get; set;}
        [AllowNull]
        public DateTime modified_at { get; set;}
        [AllowNull]
        public DateTime deleted_at { get; set;}
    }
}
