using _3_July.Models;
using _3_July.Repositories;
using Microsoft.Extensions.FileSystemGlobbing;

namespace _3_July.Services
{
    public class CourseService:ICourseService
    {
       public static List<Course> courses = new List<Course>()
            {
new Course{CourseId=111,CourseName="ADE",CourseDuration=2 },
new Course{CourseId=121,CourseName="DSGT",CourseDuration=1 },
new Course{CourseId=101,CourseName="OOP",CourseDuration=3 }



            };
       public List<Course> GetCourse()
        {
            return courses;
        }

        public Course UpdateCourse(int id, Course course)
        {

            var result = courses.FirstOrDefault(s => s.CourseId == id);
            if (result == null)
            {
                return null;
            }
            result.CourseDuration = course.CourseDuration;
            return result;
        }
        public bool DeleteCourse(int id)
        {
            var result = courses.FirstOrDefault(s => s.CourseId == id);
            if (result != null)
            {
                courses.Remove(result);
                return true;
            }
            return false;
        }

        public Course AddCourse(Course course)
        {
            courses.Add(course);
            return course;
        }

        public List<Course> GetCourseWithDuration(int duration)
        {
            var result=courses.Where(s=>s.CourseDuration.Equals(duration)).ToList();    
            return result;
        }
    }
}
