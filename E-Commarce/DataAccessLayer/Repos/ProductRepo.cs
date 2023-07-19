using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class ProductRepo : Repo, IRepo<Product, int, Product>
    {
      


        public Product Create(Product obj)
        {
            db.Products.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return false;
            }

            db.Products.Remove(product);
            return db.SaveChanges() > 0;
        }

        public List<Product> Read()
        {
            return db.Products.ToList();
        }

        public Product Read(int id)
        {
            return db.Products.Find(id);
        }

        public Product Update(Product obj)
        {
            db.Products.Update(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
