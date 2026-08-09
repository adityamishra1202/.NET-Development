using _4_Aug.Data;
using _4_Aug.Models;
using _4_Aug.Repository;

namespace _4_Aug.Services
{
    public class CourseService:ICourseService
    {

        private readonly AppDbContext context;

        public CourseService(AppDbContext context)
        {
            this.context = context;
        }

        public void AddCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var cours = context.Courses.Find(id);

            if (cours != null)
            {
                context.Courses.Remove(cours);
                context.SaveChanges();
            }
        }

        public List<Course> GetAll()
        {
            return context.Courses.ToList();
        }

        public Course GetCourse(int id)
        {
            return context.Courses.Find(id);
        }
    }
}
