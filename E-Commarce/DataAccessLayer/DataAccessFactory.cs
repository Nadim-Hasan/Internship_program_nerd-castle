using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    
    public class DataAccessFactory {


        public static IRepo<Product, int, Product> ProductData()
        {
            return new ProductRepo();
        }
    }
    
    
}
