using System.ComponentModel.DataAnnotations;

namespace _12_Aug_Assign.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "CustomerId is required")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Check-in date is required")]
        public DateTime Checkin { get; set; }

        [Required(ErrorMessage = "Check-out date is required")]
        public DateTime Checkout { get; set; }

        [Range(0, 10000000, ErrorMessage = "Total amount cannot be negative")]
        public decimal TotalAmt { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [StringLength(20, ErrorMessage = "Status cannot exceed 20 characters")]
        public string Status { get; set; } = "Confirmed";

        public Customer? Customer { get; set; }

        public ICollection<BookingRoom> BookingRooms { get; set; }
            = new List<BookingRoom>();
    }
}
