using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public  class Product_Inventory
    {

        [Key]
        public int id {  get; set; }    
        public int quentity { get; set; }


        [AllowNull]
        public DateTime created_at { get; set; }
        [AllowNull]
        public DateTime  modified_at { get; set;}
        [AllowNull]
        public DateTime deleted_at { get; set; }

    }
}
