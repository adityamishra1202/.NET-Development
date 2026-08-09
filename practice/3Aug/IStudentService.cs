using _3_July.Models;

namespace _3_July.Repositories
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetStudent(int id); 
        void AddStudent(Student student);
        void UpdateStudent(int id, Student student);
        void DeleteStudent(int id); 
    }
}
