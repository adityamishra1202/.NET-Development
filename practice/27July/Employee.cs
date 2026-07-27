using System.ComponentModel.DataAnnotations;

namespace _27_July.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Emp id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Emp name is required")]
        [StringLength(25,MinimumLength=3,ErrorMessage ="The dept name cannot exceed above the 25 letters")]
        public string Name { get; set; }
        
        public string LastName { get; set; }

        [Required(ErrorMessage = "Emp dept is required")]
        [StringLength(25,ErrorMessage = "The dept name cannot exceed above the 25 letters")]
        public string Dept {  get; set; }

        [Required(ErrorMessage = "Emp phone number is required")]
        public long PhoneNum {  get; set; } 

        public string Location {  get; set; }   

        public string Profile { get; set; }
    }
}
