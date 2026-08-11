using _10_Aug_Assign.Models;

namespace _10_Aug_Assign.Repository
{
    public interface IBookingService
    {
            
        Booking CreateBooking(Booking booking);

        List<Booking> GetBookings();

        Booking? GetBookingById(int id);

       void UpdateBooking(Booking booking); 
    }
}

