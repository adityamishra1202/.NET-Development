using System.ComponentModel.DataAnnotations;

namespace _3_July.Models
{
    public class Student
    {
   
        public int Id { get; set; }
        [Required(ErrorMessage = "Student name is mandatory")]
        public string Name { get; set; }
        [StringLength(30,ErrorMessage ="Student name must not be exceeded beyond 30 characters")]
        [Required(ErrorMessage = "Student age is mandatory")]
        [Range(18,25,ErrorMessage ="Student age must be between 18 and 25")]
        public int Age {  get; set; }
        [Required(ErrorMessage = "Student course is mandatory")]
        public string Course {  get; set; }
        [Required(ErrorMessage = "Student course is required")]
        [EmailAddress(ErrorMessage ="Invalid email input")]
        public string Email {  get; set; }  
    }
}
