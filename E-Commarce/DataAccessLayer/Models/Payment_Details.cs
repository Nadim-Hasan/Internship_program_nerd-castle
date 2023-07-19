using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Payment_Details
    {

        [Key]
        public int id { get; set; }
        public int order_id { get; set; }
        public string provider { get; set; }

        public string status { get; set; }
        public DateTime created_at { get; set; }    
        public DateTime modified_at { get; set;}

    }
}
