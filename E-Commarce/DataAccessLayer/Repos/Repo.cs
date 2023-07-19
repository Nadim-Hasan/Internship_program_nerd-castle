using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class Repo
    {
        internal AppDbContext db;
        
            internal Repo()
            {
                db = new AppDbContext();
            }
        }
}

