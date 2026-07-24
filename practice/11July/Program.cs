using System;
using System.Collections.Generic;
// Genericseg<int> n = new Genericseg<int>();
//         n.Print(100);

//         Genericseg<string> n1 = new Genericseg<string>();
//         n1.Print("Mamta");

//         Genericseg<double> n2 = new Genericseg<double>();
//         n2.Print(100.25);
class Program
{
    static void Main()
    {

    


        Genericseg<int> n = new Genericseg<int>();
        n.Print(100);

        Genericseg<string> n1 = new Genericseg<string>();
        n1.Print("Mamta");

        Genericseg<double> n2 = new Genericseg<double>();
        n2.Print(100.25);
    
        List<Employee> employees = new List<Employee>();
        List<Manager> managers = new List<Manager>();
        Boolean flag = true;
        while (flag)
        {
            Console.WriteLine("Welcome to Employee System");
            Console.WriteLine("1.Add Employee");
            Console.WriteLine("2.Add Managers");
            Console.WriteLine("3.View Employee");
            Console.WriteLine("4.View Managers");
            Console.WriteLine("5.Search Employee by Id");
            Console.WriteLine("6.Exit");
            Console.WriteLine("Enter Choice 1-6 :");


            try
            {

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.Write("Enter id : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        bool exists = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Employee id already exists");
                            break;
                        }
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter salary:");
                        double salary = Convert.ToDouble((Console.ReadLine()));
                        Employee employee = new Employee(id, name, salary);
                        employees.Add(employee);
                        Console.WriteLine("Employee Added successfully");
                        break;
                    case 2:

                        Console.Write("Enter Manager ID : ");
                        int mid = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter name : ");
                        string mname = Console.ReadLine();

                        Console.Write("Enter salary : ");
                        double msalary = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter dept : ");
                        string mdept = Console.ReadLine();

                        Manager manager = new Manager(mid, mname, msalary, mdept);

                        managers.Add(manager);

                        Console.WriteLine("Manager Added Successfully");

                        break;
                    case 3:

                        if (employees.Count == 0)
                        {
                            Console.WriteLine("No Employees in System");
                        }
                        else
                        {
                            foreach (Employee emp in employees)
                            {
                                emp.Display();
                            }
                        }

                        break;
                    case 4:

                        if (managers.Count == 0)
                        {
                            Console.WriteLine("No Manager in System");
                        }
                        else
                        {
                            foreach (Manager m in managers)
                            {
                                m.DisplayManager();
                            }
                        }

                        break;

                    case 5:


                        Console.Write("Enter Employee Id: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        bool found = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == searchId)
                            {
                                emp.Display();
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Employee not Found");
                        }

                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }



            }
            catch (FormatException e)
            {
                Console.WriteLine("Please wirte nmbers only");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        Console.WriteLine("/=============/");
        FileHandling f=new FileHandling();
        f.Filo();




    }

}

