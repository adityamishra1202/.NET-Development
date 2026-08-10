using System.ComponentModel.DataAnnotations;

namespace _8_Aug.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        public string CourseName { get; set; }

        [Range(1, 24)]
        public int Duration { get; set; }

        public int TeacherId { get; set; }

        public Teacher? Teacher { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}

