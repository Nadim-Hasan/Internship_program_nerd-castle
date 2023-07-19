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
    internal class CustomerRepo : Repo, IRepo<Customer, int, Customer>
    {
        

        public Customer Create(Customer obj)
        {
            db.Customers.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var customer = db.Customers.Find(id);
            if (customer == null)
            {
                return false;
            }

            db.Customers.Remove(customer);
            return db.SaveChanges() > 0;
        }

        public List<Customer> Read()
        {
            return db.Customers.ToList();
        }

        public Customer Read(int id)
        {
            return db.Customers.Find(id);
        }

        public Customer Update(Customer obj)
        {
            db.Customers.Update(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
