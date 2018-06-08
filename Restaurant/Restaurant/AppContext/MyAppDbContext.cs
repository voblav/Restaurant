using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Restaurant.Entity.Entities;
using Restaurant.Repositories;

namespace Restaurant.AppContext
{
    class MyAppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
