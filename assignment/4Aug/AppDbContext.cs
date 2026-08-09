
using _4_Aug.Models;
using Microsoft.EntityFrameworkCore;
namespace _4_Aug.Data

{
 
       
        public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }  
    }
}


