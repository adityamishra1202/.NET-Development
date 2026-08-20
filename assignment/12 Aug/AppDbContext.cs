using _12_Aug_Assign.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace _12_Aug_Assign.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<BookingRoom> BookingRooms { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // BookingRoom composite primary key
            modelBuilder.Entity<BookingRoom>()
                .HasKey(br => new
                {
                    br.BookingId,
                    br.RoomId
                });
            modelBuilder.Entity<Room>()
               .HasOne(r => r.Hotel)
               .WithMany(h => h.RoomList)
               .HasForeignKey(r => r.HotelId);


            // Customer 1 ---- Many Booking
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Customer)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.CustomerId);


            // Booking 1 ---- Many BookingRoom
            modelBuilder.Entity<BookingRoom>()
                .HasOne(br => br.Booking)
                .WithMany(b => b.BookingRooms)
                .HasForeignKey(br => br.BookingId);


            // Room 1 ---- Many BookingRoom
            modelBuilder.Entity<BookingRoom>()
                .HasOne(br => br.Room)
                .WithMany(r => r.BookingRooms)
                .HasForeignKey(br => br.RoomId);
        }
    }
}
