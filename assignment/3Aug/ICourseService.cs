using _3_July.Models;

namespace _3_July.Repositories
{
    public interface ICourseService
    {
        List<Course> GetCourse();

        Course UpdateCourse(int id, Course course);
        bool DeleteCourse(int id);

        Course AddCourse(Course course);   

        List<Course> GetCourseWithDuration(int courseId);   


    }
}
