using System.ComponentModel.DataAnnotations;

namespace _30_July_Assign.Models
{
    public class Department
    {
        [Required(ErrorMessage ="Department name is madatory")]
        [StringLength(10,MinimumLength=2,ErrorMessage ="The department name is incorrect")]
        public string Dept_Name {  get; set; }  
        public int Code {  get; set; }  
        public string Status {  get; set; }
    }
}
