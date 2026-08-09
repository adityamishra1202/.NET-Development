using _30_July_Assign.Models;

namespace _30_July_Assign.Services
{
    public interface IDepartmentService
    {
        public Department AddDepartment(Department department); 
        public List<Department> ShowDepartments();
        public bool DeleteDepartment(int id);
        public Department GetDepartment(int id);    
        public Department UpdateDepartment(int id,Department department);

    }
}
