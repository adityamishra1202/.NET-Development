using System.ComponentModel.DataAnnotations;

namespace _12_Aug_Assign.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hotel name is required")]
        [StringLength(50, ErrorMessage = "Hotel name cannot exceed 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required")]
        [StringLength(30, ErrorMessage = "City cannot exceed 30 characters")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Number of rooms is required")]
        [Range(1, 1000, ErrorMessage = "Rooms must be between 1 and 1000")]
        public int Rooms { get; set; }

        public ICollection<Room> RoomList { get; set; } = new List<Room>();
    }
}
