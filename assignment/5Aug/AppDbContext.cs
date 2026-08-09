using _5_July.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace _5_July.Data
{
    public class AppDbContext:DbContext
    {
       

     
            public AppDbContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
    }

