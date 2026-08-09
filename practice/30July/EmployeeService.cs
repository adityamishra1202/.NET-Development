using _30_July_Assign.Models;
using System.Xml.Linq;


namespace _30_July_Assign.Services
{
    public class EmployeeService : IEmployeeService {
        public static List<Employee> employees = new List<Employee>(){
            new Employee{Employee_ID=111,First_Name="Aditya", Last_Name="Mishra", Email="mishraaditya1202@gmail.com", Mobile_Number=9922112344, DOB="12/02/2007",Date_of_Joining="12/08/2019",Department="IT",Designation="Senior Manger",Employment_Status="Inactive",Salary=1200000,Gender='M' }

        };


        public Employee CreateEmployee(Employee emp)
        {
            employees.Add(emp);
            return emp;
        }
        public List<Employee> GetEmployee()
        {
            return employees;
        }
        public Employee UpdateEmployee(int id, Employee emp)
        {
            var answer = employees.FirstOrDefault(s => s.Employee_ID == id);
            if (answer == null)
            {
                return null;
            }
            answer.Designation = emp.Designation;
            answer.Salary = emp.Salary;
            answer.Employment_Status = emp.Employment_Status;
            return emp;


        }
        public bool DeleteEmployee(int id)
        {
            var answer = employees.FirstOrDefault(s => s.Employee_ID == id);
            if(answer == null)
            {
                return false ;
            }

            employees.Remove(answer);
            return true;

        }
        public Employee SearchEmployeeByEmail(string mail)
        {
            var answer = employees.FirstOrDefault(s => s.Email == mail);
           
            return answer;
        }
        public Employee GetEmployeeById(int id)
        {
            var answer = employees.FirstOrDefault(s => s.Employee_ID == id);
            if (answer == null)
            {
                return null;
            }
            return answer;
        }
        public Employee GetEmployeeByName(string name)
        {
            var answer = employees.FirstOrDefault(s => s.First_Name + s.Last_Name == name);
            if (answer == null)
            {
                return null;
            }
            return answer;

        }
        public List<Employee> SearchEmployeeByDepartment(string department)
        {
            var answer = employees.Where(s => s.Department.Equals(department,StringComparison.OrdinalIgnoreCase)).ToList();
            
            return answer;
        }
        public List<Employee> SearchEmployeeByStatus(string status)
        {
            var answer = employees.Where(s =>s.Employment_Status.Equals(status, StringComparison.OrdinalIgnoreCase)).ToList();
            
            return answer;
        }

    }
}