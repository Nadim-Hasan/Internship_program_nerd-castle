using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Order_Details
    {

        [Key]
        public int id { get; set; } 
        public int user_id { get; set; }

        public decimal total { get; set; }
        public int payment_id { get; set; }

        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set;}

        

    }
}
