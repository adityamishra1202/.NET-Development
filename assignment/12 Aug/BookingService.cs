
using _12_Aug_Assign.Repository;
using _12_Aug_Assign.Data;
using _12_Aug_Assign.Models;
using Microsoft.EntityFrameworkCore;


namespace _12_Aug.Services
{
    public class BookingService : IBookingService
    {
        private readonly AppDbContext context;

        public BookingService(AppDbContext context)
        {
            this.context = context;
        }


        // Create Booking
        public Booking CreateBooking(
            int customerId,
            DateTime checkin,
            DateTime checkout,
            List<int> roomIds)
        {
            // Check dates
            if (checkin.Date < DateTime.Today)
            {
                throw new ArgumentException(
                    "Check-in date cannot be in the past");
            }

            if (checkout <= checkin)
            {
                throw new ArgumentException(
                    "Check-out must be after check-in");
            }


            // Check rooms
            if (roomIds == null || roomIds.Count == 0)
            {
                throw new ArgumentException(
                    "At least one room must be selected");
            }


            // Check customer
            var customer = context.Customers
                .FirstOrDefault(c => c.Id == customerId);

            if (customer == null)
            {
                throw new ArgumentException(
                    "Customer not found");
            }


            // Remove duplicate room IDs
            roomIds = roomIds.Distinct().ToList();


            // Find rooms
            var rooms = context.Rooms
                .Where(r => roomIds.Contains(r.Id))
                .ToList();


            // Check all rooms exist
            if (rooms.Count != roomIds.Count)
            {
                throw new ArgumentException(
                    "One or more rooms are invalid");
            }


            // Calculate number of days
            int days = (checkout.Date - checkin.Date).Days;


            // Calculate total amount
            decimal total = rooms.Sum(r => r.Price * days);


            // Create Booking
            var booking = new Booking
            {
                CustomerId = customerId,
                Checkin = checkin,
                Checkout = checkout,
                TotalAmt = total,
                Status = "Confirmed"
            };


            // Create multiple BookingRoom records
            foreach (var room in rooms)
            {
                booking.BookingRooms.Add(
                    new BookingRoom
                    {
                        RoomId = room.Id,
                        Price = room.Price * days
                    });
            }


            // Save Booking + BookingRooms
            context.Bookings.Add(booking);

            context.SaveChanges();

            return booking;
        }


        // Get Booking By Id
        public Booking? GetBookingById(int id)
        {
            return context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.BookingRooms)
                .ThenInclude(br => br.Room)
                .FirstOrDefault(b => b.Id == id);
        }


        // Get All Bookings
        public List<Booking> GetBookings()
        {
            return context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.BookingRooms)
                .ThenInclude(br => br.Room)
                .ToList();
        }


        // Get Rooms
        public List<Room> GetRooms()
        {
            return context.Rooms
                .Include(r => r.Hotel)
                .ToList();
        }
    }
}