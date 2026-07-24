using System;

class Program
{
    static void Main()
    {
        bool login = false;

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter Username : ");
            string uname = Console.ReadLine();

            Console.Write("Enter Password : ");
            string pass = Console.ReadLine();

            if (uname == "admin" && pass == "admin123")
            {
                Console.WriteLine("Login Successful");
                login = true;
                break;
            }
            else
            {
                Console.WriteLine("Invalid Login");
                Console.WriteLine("Attempts Left : " + (3 - i));
            }
        }

        if (!login)
        {
            throw new LoginFailedException();
        }

        StoreManager store = new StoreManager();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Stationery Store Management System");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Add Stationery Item");
            Console.WriteLine("2. Display All Items");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Update Item");
            Console.WriteLine("5. Delete Item");
            Console.WriteLine("6. Purchase Item");
            Console.WriteLine("7. View Low Stock Items");
            Console.WriteLine("8. Sort Items");
            Console.WriteLine("9. Exit");

            Console.Write("Enter Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Select Item Type");
                        Console.WriteLine("1. Notebook");
                        Console.WriteLine("2. Pen");
                        Console.WriteLine("3. Marker");

                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Item Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Item Name : ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Category : ");
                        string category = Console.ReadLine();

                        Console.Write("Enter Brand : ");
                        string brand = Console.ReadLine();

                        Console.Write("Enter Price : ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Quantity : ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        if (type == 1)
                        {
                            Console.Write("Enter Pages : ");
                            int pages = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Paper Type : ");
                            string paper = Console.ReadLine();

                            Notebook n = new Notebook(id, name, category, price,
                                quantity, brand, pages, paper);

                            store.AddItem(n);
                        }
                        else if (type == 2)
                        {
                            Console.Write("Enter Ink Color : ");
                            string color = Console.ReadLine();

                            Console.Write("Enter Pen Type : ");
                            string penType = Console.ReadLine();

                            Pen p = new Pen(id, name, category, price,
                                quantity, brand, color, penType);

                            store.AddItem(p);
                        }
                        else if (type == 3)
                        {
                            Console.Write("Permanent Marker (true/false) : ");
                            bool permanent = Convert.ToBoolean(Console.ReadLine());

                            Marker m = new Marker(id, name, category, price,
                                quantity, brand, permanent);

                            store.AddItem(m);
                        }

                        break;
                                            case 2:

                        store.DisplayAllItems();
                        break;

                    case 3:

                        Console.Write("Enter Item Id : ");
                        int sid = Convert.ToInt32(Console.ReadLine());

                        StationeryItem item = store.SearchItem(sid);
                        item.DisplayDetails();

                        break;

                    case 4:

                        Console.Write("Enter Item Id : ");
                        int uid = Convert.ToInt32(Console.ReadLine());

                        store.UpdateItem(uid);

                        break;

                    case 5:

                        Console.Write("Enter Item Id : ");
                        int did = Convert.ToInt32(Console.ReadLine());

                        store.DeleteItem(did);

                        break;

                    case 6:

                        Console.Write("Enter Item Id : ");
                        int pid = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Purchase Quantity : ");
                        int qty = Convert.ToInt32(Console.ReadLine());

                        store.PurchaseItem(pid, qty);

                        break;

                    case 7:

                        store.ViewLowStockItems();

                        break;

                    case 8:

                        Console.WriteLine("1. Sort By Price");
                        Console.WriteLine("2. Sort By Name");
                        Console.WriteLine("3. Sort By Quantity");

                        int sort = Convert.ToInt32(Console.ReadLine());

                        switch (sort)
                        {
                            case 1:
                                store.SortByPrice();
                                break;

                            case 2:
                                store.SortByName();
                                break;

                            case 3:
                                store.SortByQuantity();
                                break;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }

                        break;

                    case 9:

                        Console.WriteLine("Thank You");
                        Console.WriteLine("Visit Again");
                        return;

                    default:

                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
