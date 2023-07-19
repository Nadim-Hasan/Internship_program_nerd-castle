using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Cart_Items
    {

        [Key]
        public int id { get; set; }
        public int session_id { get; set; } 
        public int product_id { get; set; }
        public virtual ICollection<Product> Products { get; set; }   


        public int quantity { get; set; }

        [AllowNull]
        public DateTime created_at { get; set; }
        [AllowNull]
        public DateTime modified_at { get; set;}

    }
}
