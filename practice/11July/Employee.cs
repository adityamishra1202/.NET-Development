public class Employee
{
    public int Id;
    String EmpName;

    public double MonthlySalary;


    public Employee(int i,String e,double m)
    {
        Id=i;
        EmpName=e;
        MonthlySalary=m;
    }
    double CalculateAnnualSalary()
    {
        return MonthlySalary*12;
    }

    public void Display()
    {
        Console.WriteLine("ID"+Id);
        Console.WriteLine("Employee name"+EmpName);
        Console.WriteLine("Monlthy salary is"+MonthlySalary);
        Console.WriteLine("Annual"+CalculateAnnualSalary());
        Console.WriteLine("//////////////////");
    }


}