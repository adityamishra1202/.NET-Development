using System.ComponentModel.DataAnnotations;

namespace _12_Aug_Assign.Models
{
    public class Room
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "HotelId is required")]
        public int HotelId { get; set; }

        [Required(ErrorMessage = "Room number is required")]
        [Range(1, 9999, ErrorMessage = "Room number must be valid")]
        public int RoomNumber { get; set; }

        [Required(ErrorMessage = "Room type is required")]
        [StringLength(30, ErrorMessage = "Room type cannot exceed 30 characters")]
        public string RoomType { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 1000000, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        public Hotel? Hotel { get; set; }

        public ICollection<BookingRoom> BookingRooms { get; set; }
            = new List<BookingRoom>();
    }
}
