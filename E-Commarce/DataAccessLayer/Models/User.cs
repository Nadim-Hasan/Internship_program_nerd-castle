using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public  class User
    {
        public int id { get; set; }
        public string username { get; set; }
        
        public string password { get; set; } 
        public string user_address { get; set; }
    }
}
