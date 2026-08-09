using System.ComponentModel.DataAnnotations;

namespace _5_July.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Customer Name is required")]
        [StringLength(100, MinimumLength = 2)]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Total Amount is required")]
        [Range(1, 100000)]
        public decimal TotalAmount { get; set; }

    }
}
