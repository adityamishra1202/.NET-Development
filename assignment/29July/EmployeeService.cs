using _29_July.Models;
using Microsoft.AspNetCore.Mvc;

namespace _29_July.Services
{
    public class EmployeeService:IEmployeeService
    {
        private static List<Employee> employees = new List<Employee>()
{
    new Employee { Id = 101, Name = "Manta", PhoneN = 789654, Email = "mamta@gmail.com", DeptId = 11 },
    new Employee { Id = 102, Name = "Bob", PhoneN = 960054, Email = "bob@gmail.com", DeptId = 13 },
    new Employee { Id = 103, Name = "John", PhoneN = 654123, Email = "jo@gmail.com", DeptId = 12 },
    new Employee { Id = 104, Name = "Alice", PhoneN = 6054123, Email = "joal@gmail.com", DeptId = 13 }
};

        public List<Employee> getEmployees()
        {
            return employees;
        }

        public List<Employee>? getEmployeee(int deptid)
        {
            return employees.Where(e => e.DeptId == deptid).ToList();

        }

        public Employee? getEmployeeName(string Name)
        {
            return employees.FirstOrDefault(e => e.Name == Name);
        }

        public Employee addEmployee(Employee employee)
        {
            employees.Add(employee);

            return employee;
        }


    }
}
