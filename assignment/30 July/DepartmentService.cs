using _30_July_Assign.Models;
using System.Transactions;



namespace _30_July_Assign.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly IEmployeeService _service;
        public DepartmentService(IEmployeeService service)
        {
            _service = service;
        }
        
        private static List<Department> departments=new List<Department>() 
        {
           new Department{Dept_Name="HR" ,Code=1001, Status="Inactive" }
        };
        
        public Department AddDepartment(Department department)
        {
            bool flag = false;
           foreach(Department d in departments)
            {
                if (department.Dept_Name.ToLower()== d.Dept_Name.ToLower())
                {
                    flag = true;
                    break;
                }
                
            }
           if(flag)
            {
                return null;
            }
           departments.Add(department);
           return department;
        }
        public List<Department> ShowDepartments()
        {
            return departments;
        }
        public bool DeleteDepartment(int id)
        {
            bool turn = true;
            var result = departments.FirstOrDefault(e => e.Code == id);
            if(result == null)
            {
                return false;
            }
            var ans = _service.GetEmployee();
           
                foreach (Employee e in ans)
                {
                if (result.Dept_Name == e.Department)
                    {
                        turn = false;
                    }
                }
            
                if (turn)
                {
                    departments.Remove(result);
                    return true;
                }
          
                    return false;
     
            


        }
        public Department GetDepartment(int id)
        {
            var result = departments.FirstOrDefault(e => e.Code == id);
            if(result == null)
            {
                return null;
            }
            return result;
        }
        public Department UpdateDepartment(int id, Department department)
        {
            bool flag = false;
            var result = departments.FirstOrDefault(e => e.Code == id);
            if(result == null)
            {
                return null;
            }
            foreach(Department d in departments)
            {
                
               if(d.Code!=id && department.Dept_Name.ToLower()==d.Dept_Name.ToLower())
                {
                   flag= true;
                    break;
                }

            }
            if (flag) 
            {
                return null;
            }

            result.Dept_Name=department.Dept_Name;

            result.Code = department.Code;
            return result;


        }
    }
}
