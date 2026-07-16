using System;
using System.Collections.Generic;
class Program
{


    static void Main()
    {
        Console.WriteLine("Enter Employee Name:");
        string empName = Console.ReadLine();

        Console.WriteLine("Enter Employee ID:");
        int empId = Convert.ToInt32(Console.ReadLine());

        Employee emp = new Employee(empId, empName);

        Console.WriteLine("Welcome " + emp.EmpName);
        List<Vehicle> vehicles = new List<Vehicle>();
        while (true)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("ABC MOTORS");
            Console.WriteLine("==============================");
            Console.WriteLine("1.Add a vehicle");
            Console.WriteLine("2.View All Vehicles");
            Console.WriteLine("3.Search Vehicle");
            Console.WriteLine("4.Update Vehicle price");
            Console.WriteLine("5.Delete Vehicle");
            Console.WriteLine("6.Calculate Discount:For Car:10%;For Bike:5%;For Truck:15%");
            Console.WriteLine("7.Show vehicle details");
            Console.WriteLine("8.Exit");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the id of the vehicle to add");
                    int id = Convert.ToInt32(Console.ReadLine());
                    bool exists = false;
                    foreach (Vehicle v in vehicles)
                    {
                        if (v.Vid == id)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (exists)
                    {
                        Console.WriteLine("This id is already registered");
                        break;
                    }
                    Console.WriteLine("Enter the name of the vehicle");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the type of the vehicle");
                    string type = Console.ReadLine();
                    Console.WriteLine("Enter the brand of the vehicle");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Enter the price of the vehicle");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enetr the manufacting year in format DD/MM/YYYY");
                    string year = Console.ReadLine();
                    Vehicle vehicle = new Vehicle(id, name, type, brand, price, year);
                    vehicles.Add(vehicle);
                    break;
                case 2:
                    if (vehicles.Count == 0)
                    {
                        Console.WriteLine("First add the vehicles");
                        break;
                    }
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("ID    Name    Brand    Type    Price");
                    Console.WriteLine("-----------------------------------------");
                    foreach (Vehicle v in vehicles)
                    {
                        v.display();
                    }

                    break;

                case 3:
                    Console.WriteLine("enter the id of the vehicle you want to search");
                    int searchId = Convert.ToInt32(Console.ReadLine());
                    bool idexist = false;
                    foreach (Vehicle v in vehicles)
                    {
                        if (v.Vid == searchId)
                        {
                            v.display();
                            Console.WriteLine("The manufacturing year is" + v.Vyear);
                            idexist = true;
                            break;
                        }
                    }
                    if (!idexist)
                    {
                        Console.WriteLine("Vehicle not found");
                        break;
                    }
                    break;
                case 4:
                    Console.WriteLine("enter the id to update the price of the vehicle");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    bool iexist = false;
                    foreach (Vehicle v in vehicles)
                    {
                        if (v.Vid == Id)
                        {
                            Console.WriteLine("enter the price to update");
                            int upPrice = Convert.ToInt32(Console.ReadLine());
                            v.Vprice = upPrice;
                            Console.WriteLine("The Price of Id number " + Id + " updated successfully");
                            iexist = true;
                            break;
                        }
                    }
                    if (!iexist)
                    {
                        Console.WriteLine("Vehicle id not found");
                        break;
                    }
                    break;

                case 5:
                    Console.WriteLine("enter the id of tghe evhicle to delete");
                    int dId = Convert.ToInt32(Console.ReadLine());
                    bool dexist = false;
                    int count = 0;
                    foreach (Vehicle v in vehicles)
                    {

                        if (v.Vid == dId)
                        {
                            dexist = true;
                            break;
                        }
                        count += 1;
                    }
                    if (dexist)
                    {
                        vehicles.RemoveAt(count);
                        Console.WriteLine("Vehicel deleted successfully");
                        break;
                    }
                    if (!dexist)
                    {
                        Console.WriteLine("Vehicle id not found");
                        break;
                    }
                    break;

                case 6:
                    
                    Console.WriteLine("enter the id of the vehicle");
                    int iid = Convert.ToInt32(Console.ReadLine());
                    foreach (Vehicle v in vehicles)
                    {
                        if (v.Vid == iid && v.Vtype == "Car")
                        {
                            Console.WriteLine("The price of the vehicle is" + v.Vprice);
                            Console.WriteLine("The discount given will be" + ((10 * v.Vprice) / 100));
                            Console.WriteLine("The final Amout is" + (v.Vprice - ((10 * v.Vprice) / 100)));
                        }
                        else if (v.Vid == iid && v.Vtype == "Bike")
                        {
                            Console.WriteLine("The price of the vehicle is" + v.Vprice);
                            Console.WriteLine("The discount given will be" + ((5 * v.Vprice) / 100));
                            Console.WriteLine("The final Amout is" + (v.Vprice - ((5 * v.Vprice) / 100)));
                        }
                        else if (v.Vid == iid && v.Vtype == "Truck")
                        {
                            Console.WriteLine("The price of the vehicle is" + v.Vprice);
                            Console.WriteLine("The discount given will be" + ((12 * v.Vprice) / 100));
                            Console.WriteLine("The final Amout is" + (v.Vprice - ((12 * v.Vprice) / 100)));
                        }

                    }
                    break;

                case 7:
                    Console.WriteLine("Enter the choice for vehicle you want to see details ");
                    Console.WriteLine("Car   Bike   Truck");
                    string Vchoice = Console.ReadLine();
                    switch (Vchoice)
                    {
                        case "Car":
                            Console.WriteLine("Car is a four wheeler");
                            Console.WriteLine("Suitable for family");

                            break;
                        case "Bike":
                            Console.WriteLine("Bike is fuel efficient");
                            Console.WriteLine("Suitable for city rides");
                            break;
                        case "Truck":
                            Console.WriteLine("Truck is used for trnsportation");
                            Console.WriteLine("Heavy load vehicle");
                            break;

                    }
                    break;
                case 8:
                    Console.WriteLine("Thank you for using ABC Motor System");
                    return;
                default:
                    Console.WriteLine("Entered Wrongly");
                    break;

            }
        }
    }
}

