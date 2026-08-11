using System.ComponentModel.DataAnnotations;

namespace _10_Aug_Assign.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vehicle name is required")]

        [Range(0001, 9999)]
        public int VehicleNumber { get; set; }


        [Required(ErrorMessage = "Vehicle brand is required")]

        public string Brand { get; set; }
        [Required(ErrorMessage = "Vehicle price is required")]
        [Range(1000000, 10000000)]
        public decimal Price {  get; set; } 
    }
}
