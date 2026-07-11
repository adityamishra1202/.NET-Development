
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> emp = new List<Employee>()
        {
            new PermanentEmployee(101,"Ram","IT"),
            new ContractEmployee(102,"Shyam","HR"),
            new PermanentEmployee(103,"Amit","CSE")
        };

        foreach (Employee e in emp)
            e.Display();

        List<LeaveRequest> leave = new List<LeaveRequest>()
        {
            new LeaveRequest(1,101,2,"Medical"),
            new LeaveRequest(2,103,5,"Vacation")
        };

        foreach (LeaveRequest l in leave)
            l.Display();

        Console.WriteLine("Permanent Employees");
        foreach (Employee e in emp)
            if (e is PermanentEmployee)
                e.Display();

        Console.WriteLine("Employee ID 103");
        foreach (Employee e in emp)
            if (e.EmployeeId == 103)
                e.Display();

        Console.WriteLine("Total Employees = " + emp.Count);
        Console.WriteLine("Total Leave Requests = " + leave.Count);
    }
}
