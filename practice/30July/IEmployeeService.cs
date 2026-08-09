
using _30_July_Assign.Models;

namespace _30_July_Assign.Services
{
    public interface IEmployeeService
    {
        public Employee CreateEmployee(Employee emp);
        public List<Employee> GetEmployee();
        public Employee GetEmployeeById(int id);
        public Employee GetEmployeeByName(string name); 
        public Employee UpdateEmployee(int id,Employee emp);
        public bool DeleteEmployee(int id); 
        public Employee SearchEmployeeByEmail(string mail);
        public List<Employee> SearchEmployeeByDepartment(string department);    
        public List<Employee> SearchEmployeeByStatus(string status);    

    }
}
