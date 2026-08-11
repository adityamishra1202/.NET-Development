using _10_Aug_Assign.Data;
using _10_Aug_Assign.Models;
using _10_Aug_Assign.Repository;

namespace _10_Aug_Assign.Service
{
    public class BookingService:IBookingService
    {
        private readonly AppDbContext context;

        public BookingService(AppDbContext context)
        {
            this.context = context;
        }
        public Booking CreateBooking(Booking booking)
        {
            if (booking.BookDate.Date < DateTime.UtcNow.Date)
                throw new ArgumentException("Travel Date cannot be in the past");

            var vehicle= context.Vehicles
                .FirstOrDefault(b => b.Id == booking.VehicleId);

            if (vehicle == null)
                throw new ArgumentException("Invalid Bus");

            if (booking.BPrice > vehicle.Price)
                throw new ArgumentException(
                    "price must be between 1000000 to 10000000");



            var AlreadyBooked = context.Bookingss.Any(b =>
                b.Id != booking.Id &&
                b.BookDate.Date == booking.BookDate.Date &&
                b.BPrice == booking.BPrice);
                

            if (AlreadyBooked)
                throw new ArgumentException(
                    "This seat is already booked for the selected date");

            var costum = context.Costumers
                .FirstOrDefault(p => p.Id == booking.CostumerId);

            if (costum == null)
                throw new ArgumentException("Invalid Costumer");

            context.Bookingss.Add(booking);
            context.SaveChanges();

            return booking;
        }
       public  List<Booking> GetBookings()
        {
            return context.Bookingss.ToList();
        }

       public Booking? GetBookingById(int id)
        {
            return context.Bookingss.Find( id); 
            
        }

       public void UpdateBooking(Booking booking)
        {
            context.Bookingss.Update(booking);
            context.SaveChanges();
        }
    }
}
