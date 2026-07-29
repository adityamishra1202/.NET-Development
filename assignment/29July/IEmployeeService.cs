
 using _29_July.Models;


namespace _29_July.Services
{
    public interface IEmployeeService
    {
        List<Employee> getEmployees();

       List< Employee >getEmployeee(int deptid);

        Employee getEmployeeName(string Name);

        Employee addEmployee(Employee employee);
    }
}
