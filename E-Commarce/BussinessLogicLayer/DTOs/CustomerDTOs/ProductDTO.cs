using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DTOs.CustomerDTOs
{
    public class ProductDTO
    {

        
        public int id { get; set; }
        public string name { get; set; }

        public string product_img_url { get; set; }
        public string description { get; set; }

        public decimal price { get; set; }

        [AllowNull]
        public DateTime created_at { get; set; }
        [AllowNull]
        public DateTime mofidied_at { get; set; }
        [AllowNull]
        public DateTime deleted_at { get; set; }

    }
}
