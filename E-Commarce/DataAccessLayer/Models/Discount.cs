using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Discount
    {

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool active { get; set; }

        [AllowNull]
        public DateTime created_at { get; set; }
        [AllowNull]
        public DateTime mofidied_at { get; set; }
        [AllowNull]
        public DateTime deleted_at { get; set; }
    }
}
