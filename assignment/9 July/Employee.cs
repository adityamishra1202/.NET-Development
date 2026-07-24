using System;

abstract class Employee
{
    public int EmployeeId;
    public string Name;
    public string Department;
    public int LeaveBalance;

    public Employee(int id, string name, string dept)
    {
        EmployeeId = id;
        Name = name;
        Department = dept;
    }

    public abstract void SetLeaveBalance();

    public void Display()
    {
        Console.WriteLine(EmployeeId + " " + Name + " " + Department + " " + LeaveBalance);
    }
}