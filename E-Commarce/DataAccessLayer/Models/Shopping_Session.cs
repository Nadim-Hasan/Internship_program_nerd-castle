using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public  class Shopping_Session
    {

        [Key]
        public int id {  get; set; }
        public int user_id { get; set; }
        public decimal total { get; set;}




        [AllowNull]
        public DateTime? created_at { get; set; }
        [AllowNull]
        public DateTime? modified_at { get; set;}
    }
}
