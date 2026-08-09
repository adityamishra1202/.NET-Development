using _4_Aug.Models;

namespace _4_Aug.Repository
{
    public interface ICourseService
    {
        List<Course> GetAll();

        Course GetCourse(int id);

        void AddCourse(Course course);

       

        void DeleteCourse(int id);
    }
}
