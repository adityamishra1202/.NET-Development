using _12_Aug_Assign.Models;

namespace _12_Aug_Assign.Repository
{
    
        public interface IBookingService
        {
            Booking CreateBooking(
                int customerId,
                DateTime checkin,
                DateTime checkout,
                List<int> roomIds);

            Booking? GetBookingById(int id);

            List<Booking> GetBookings();

            List<Room> GetRooms();
        }
    }

