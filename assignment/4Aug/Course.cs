using System.ComponentModel.DataAnnotations;

namespace _4_Aug.Models
{
    public class Course
    {
     public int CourseId { get; set; }

        [Required(ErrorMessage ="Coursename is required")]
        [StringLength(8,MinimumLength =2,ErrorMessage ="The course name is invalid")]
    public string CourseName { get; set; }

        [Required(ErrorMessage = "Courseduration is required")]
        [Range(5,3,ErrorMessage ="The courseduration is invalid")]
        public int CourseDuration { get; set; }

}
}
