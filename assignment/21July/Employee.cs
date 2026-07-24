using System.ComponentModel.DataAnnotations;

namespace _21_July_Assign.Models
{
    public class Employee
    {

        public int Employee_Id { get; set; }


        [Required(ErrorMessage = "Employee name is mandatory to submit form")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid name please enetr correctly")]
        public string Employee_Name { get; set; }

        [Required(ErrorMessage = "Employee department is mandatory to submit form")]
        public string Department {  get; set; }

        [Required(ErrorMessage = "Employee Salary is mandatory to submit form")]
        [Range(10000, 250000, ErrorMessage = "Extending the salary policy of the company")]
        public int Salary {  get; set; }

        [Required(ErrorMessage = "Must enetr the email")]
        [EmailAddress(ErrorMessage ="Invalid Email entry")]
        public string Email {  get; set; }

    }
}
