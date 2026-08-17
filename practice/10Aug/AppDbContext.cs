using _10_Aug.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Passenger> Passengers => Set<Passenger>();

    public DbSet<Bus> Buses => Set<Bus>();

    public DbSet<State> States => Set<State>();

    public DbSet<Booking> Bookings => Set<Booking>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Passenger)
            .WithMany()
            .HasForeignKey(b => b.PassengerId);

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Bus)
            .WithMany()
            .HasForeignKey(b => b.BusId);

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.State)
            .WithMany()
            .HasForeignKey(b => b.StateId);

        // Prevent the same seat from being booked twice
        modelBuilder.Entity<Booking>()
            .HasIndex(b => new
            {
                b.BusId,
                b.TravelDate,
                b.SeatNumber
            })
            .IsUnique();
    }
}
