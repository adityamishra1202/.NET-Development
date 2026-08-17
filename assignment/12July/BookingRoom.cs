using System.ComponentModel.DataAnnotations;

namespace _12_Aug_Assign.Models
{
    public class BookingRoom
    {
        public int BookingId { get; set; }

        public int RoomId { get; set; }

        [Range(0, 1000000, ErrorMessage = "Price cannot be negative")]
        public decimal Price { get; set; }

        public Booking? Booking { get; set; }

        public Room? Room { get; set; }
    }
}
