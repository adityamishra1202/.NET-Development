using _10_Aug_Assign.Models;
using Microsoft.EntityFrameworkCore;

namespace _10_Aug_Assign.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles => Set<Vehicle>();

        public DbSet<Costumer> Costumers => Set<Costumer>();

        public DbSet<Booking> Bookingss => Set<Booking>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Vehicle)
                .WithMany()
                .HasForeignKey(b => b.VehicleId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Costumer)
                .WithMany()
                .HasForeignKey(b => b.CostumerId);

        }

        }
}
