using System.ComponentModel.DataAnnotations;

namespace _22_July_Assign.Models
{
    public class Manufacture
    {
        [Required(ErrorMessage = "Manufacturer name is mandatory to submit form")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid name please enetr correctly")]
        public string Manufacturer_Name { get; set; }

        [Required(ErrorMessage = "country is mandatory to submit form")]
        [StringLength(45, MinimumLength = 4, ErrorMessage = "The country name must be between 4 to 45 characters")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Contact Number is mandatory to submit form")]
        public long ContactNumber { get; set; }
        [Required(ErrorMessage = "Must enetr the email")]
        [EmailAddress(ErrorMessage ="Please Enter the email correctly ")]

        public string Email{ get; set; }
    }
}
