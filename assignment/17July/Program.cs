class Program
{
    static void Main()
    {
        List<Costumer> costumers = new List<Costumer>();
        List<Product> products = new List<Product>();
        List<Category> categories = new List<Category>();
        List<Order> orders = new List<Order>();
        List<Payment> payments = new List<Payment>();

        Costumer currentCustomer = null;
        while (true)
        {
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    while (true)
                    {
                        // Customer Menu
                        Console.WriteLine("1.Register");
                        Console.WriteLine("2.Login");
                        Console.WriteLine("3.Logout");
                        Console.WriteLine("4.Update Profile");
                        Console.WriteLine("5.Change Password");
                        Console.WriteLine("6.View Products");
                        Console.WriteLine("7.Adding to cart");
                        Console.WriteLine("8.Remove item from cart");
                        Console.WriteLine("9.Place order");
                        Console.WriteLine("10.Payment");
                        Console.WriteLine("11.Order History");
                        Console.WriteLine("12.Back");




                        Console.WriteLine("Enter choice");
                        int cchoice = Convert.ToInt32(Console.ReadLine());
                        switch (cchoice)
                        {
                            case 1:

                                Console.Write("Enter User Id : ");
                                long id = Convert.ToInt64(Console.ReadLine());

                                bool exists = false;

                                foreach (Costumer c in costumers)
                                {
                                    if (c.UserId == id)
                                    {
                                        exists = true;
                                        break;
                                    }
                                }

                                if (exists)
                                {
                                    Console.WriteLine("User Id already exists");
                                    break;
                                }

                                Console.Write("Enter User Name : ");
                                string uname = Console.ReadLine();

                                Console.Write("Enter Name : ");
                                string name = Console.ReadLine();

                                Console.Write("Enter Address : ");
                                string address = Console.ReadLine();

                                Console.Write("Enter Password : ");
                                string pass = Console.ReadLine();

                                Costumer cust = new Costumer(id, uname, name, address, pass);

                                costumers.Add(cust);

                                Console.WriteLine("Registration Successful");

                                break;

                            case 2:

                                bool login = false;
                                string cname = "";

                                Console.Write("Enter User Id : ");
                                long idd = Convert.ToInt64(Console.ReadLine());

                                Console.Write("Enter Password : ");
                                string passs = Console.ReadLine();

                                foreach (Costumer c in costumers)
                                {
                                    if (c.UserId == idd && c.Password == passs)
                                    {
                                        login = true;
                                        cname = c.Name;
                                        currentCustomer = c;
                                        break;
                                    }
                                }

                                if (login)
                                {
                                    Console.WriteLine("Welcome " + cname);

                                }
                                else
                                {
                                    Console.WriteLine("Invalid User Id or Password");
                                }

                                break;

                            case 3:

                                if (currentCustomer != null)
                                {
                                    currentCustomer.logOut();
                                    currentCustomer = null;
                                }
                                else
                                {
                                    Console.WriteLine("No customer is logged in.");
                                }

                                break;
                            case 4:

                                if (currentCustomer != null)
                                {
                                    Console.Write("Enter New User Name : ");
                                    string upuname = Console.ReadLine();

                                    Console.Write("Enter New Name : ");
                                    string upname = Console.ReadLine();

                                    Console.Write("Enter New Address : ");
                                    string upaddress = Console.ReadLine();

                                    Console.Write("Enter New Password : ");
                                    string uppass = Console.ReadLine();

                                    currentCustomer.update(upuname, upname, upaddress, uppass);

                                    Console.WriteLine("Profile Updated Successfully");
                                }
                                else
                                {
                                    Console.WriteLine("Please Login First");
                                }

                                break;
                            case 5:

                                if (currentCustomer != null)
                                {
                                    Console.Write("Enter Current Password : ");
                                    string oldPass = Console.ReadLine();

                                    if (currentCustomer.Password == oldPass)
                                    {
                                        Console.Write("Enter New Password : ");
                                        string newPass = Console.ReadLine();

                                        currentCustomer.Cpassword(newPass);

                                        Console.WriteLine("Password Changed Successfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Current Password is Incorrect");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please Login First");
                                }
                                break;
                            case 6:

                                if (products.Count == 0)
                                {
                                    Console.WriteLine("No Products Available");
                                }
                                else
                                {
                                    foreach (Product p in products)
                                    {
                                        p.display();
                                        Console.WriteLine("----------------------------");
                                    }
                                }

                                break;
                            case 7:
                                if (currentCustomer != null)
                                {
                                    Console.WriteLine("Enter the id of the product");
                                    long cartId = Convert.ToInt64(Console.ReadLine());
                                    bool cartExist = false;
                                    foreach (Product p in products)
                                    {
                                        if (p.Pid == cartId)
                                        {
                                            currentCustomer.AddCart(cartId, p.Pname, p.Category, p.description, p.price, p.quantity, p.brand, p.discount, p.rating);
                                            Console.WriteLine("Product added successfully");
                                            cartExist = true;
                                            break;
                                        }

                                    }
                                    if (!cartExist)
                                    {
                                        Console.WriteLine("No id found");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please login first");
                                }
                                break;
                            case 8:
                                if (currentCustomer != null)
                                {
                                    Console.WriteLine("Enter the id of the product");
                                    long remId = Convert.ToInt64(Console.ReadLine());
                                    currentCustomer.delete(remId);
                                }
                                else
                                {
                                    Console.WriteLine("Please login first");
                                }
                                break;
                            case 9:


                                if (currentCustomer != null)
                                {
                                    Console.Write("Enter Order Id : ");
                                    int oid = Convert.ToInt32(Console.ReadLine());

                                    bool orderExists = false;

                                    foreach (Order o in orders)
                                    {
                                        if (o.OrderId == oid)
                                        {
                                            orderExists = true;
                                            break;
                                        }
                                    }

                                    if (orderExists)
                                    {
                                        Console.WriteLine("Order Id already exists");
                                        break;
                                    }

                                    Order obj = new Order(oid, currentCustomer.UserId, "Placed");

                                    orders.Add(obj);

                                    Console.WriteLine("Order Placed Successfully");
                                }
                                else
                                {
                                    Console.WriteLine("Please Login First");
                                }

                                break;
                            case 10:

                                if (currentCustomer != null)
                                {
                                    Console.Write("Enter Payment Id : ");
                                    int pid = Convert.ToInt32(Console.ReadLine());

                                    bool payExist = false;

                                    foreach (Payment p in payments)
                                    {
                                        if (p.PaymentId == pid)
                                        {
                                            payExist = true;
                                            break;
                                        }
                                    }

                                    if (payExist)
                                    {
                                        Console.WriteLine("Payment Id already exists");
                                        break;
                                    }

                                    Console.Write("Enter Order Id : ");
                                    int oid = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter Amount : ");
                                    int amt = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter Payment Mode : ");
                                    string mode = Console.ReadLine();

                                    Payment pay = new Payment(pid, oid, amt, mode, "Paid");

                                    payments.Add(pay);

                                    Console.WriteLine("Payment Successful");
                                }
                                else
                                {
                                    Console.WriteLine("Please Login First");
                                }

                                break;



                            case 11:

                                if (currentCustomer != null)
                                {
                                    bool found = false;

                                    foreach (Order o in orders)
                                    {
                                        if (o.CustomerId == currentCustomer.UserId)
                                        {
                                            o.display();
                                            Console.WriteLine("----------------------");
                                            found = true;
                                        }
                                    }

                                    if (!found)
                                    {
                                        Console.WriteLine("No Orders Found");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please Login First");
                                }

                                break;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }

                        if (cchoice == 12)
                        {
                            Console.WriteLine("Leaving the costumer");
                            break;
                        }
                    }


                    break;


                case 2:
                    Console.Write("Username : ");
                    string user = Console.ReadLine();

                    Console.Write("Password : ");
                    string apass = Console.ReadLine();

                    if (user == "admin" && apass == "admin123")
                    {
                        while (true)
                        {
                            Console.WriteLine("1. Add Product");
                            Console.WriteLine("2. Update Product");
                            Console.WriteLine("3. Delete Product");
                            Console.WriteLine("4. Search Product");
                            Console.WriteLine("5. View Products");
                            Console.WriteLine("6. Add Category");
                            Console.WriteLine("7. Delete Category");
                            Console.WriteLine("8.Update category");
                            Console.WriteLine("9.Exit");
                            Console.WriteLine("Enter the choice 1-9");

                            int adminChoice = Convert.ToInt32(Console.ReadLine());

                            switch (adminChoice)
                            {

                                case 1:

                                    Console.Write("Enter Product Id : ");
                                    long pid = Convert.ToInt64(Console.ReadLine());

                                    bool found = false;
                                    bool cExist = false;

                                    foreach (Product p in products)
                                    {
                                        if (p.Pid == pid)
                                        {
                                            found = true;
                                            break;
                                        }
                                    }

                                    if (found)
                                    {
                                        Console.WriteLine("Product Id already exists.");
                                        break;
                                    }

                                    Console.Write("Enter Product Name : ");
                                    string pname = Console.ReadLine();

                                    Console.Write("Enter Category : ");
                                    string category = Console.ReadLine();

                                    foreach (Category c in categories)
                                    {
                                        if (c.Cname == category)
                                        {
                                            Console.WriteLine("Correct category entered");
                                            cExist = true;
                                        }
                                    }
                                    if (!cExist)
                                    {
                                        Console.WriteLine("No such category exists");
                                        break;
                                    }


                                    Console.Write("Enter Description : ");
                                    string desc = Console.ReadLine();

                                    Console.Write("Enter Price : ");
                                    int price = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter Quantity : ");
                                    int qty = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter Brand : ");
                                    string brand = Console.ReadLine();

                                    Console.Write("Enter Discount : ");
                                    float discount = Convert.ToSingle(Console.ReadLine());

                                    Console.Write("Enter Rating : ");
                                    float rating = Convert.ToSingle(Console.ReadLine());

                                    Product pro = new Product(pid, pname, category, desc, price, qty, brand, discount, rating);

                                    products.Add(pro);

                                    Console.WriteLine("Product Added Successfully");

                                    break;



                                case 2:

                                    Console.Write("Enter Product Id to Update : ");
                                    long upid = Convert.ToInt64(Console.ReadLine());
                                    bool ccExist = false;
                                    bool ufound = false;

                                    foreach (Product p in products)
                                    {

                                        if (p.Pid == upid)
                                        {
                                            ufound = true;

                                            Console.Write("Enter New Product Name : ");
                                            p.Pname = Console.ReadLine();

                                            Console.Write("Enter New Category : ");
                                            string ucat = Console.ReadLine();
                                            foreach (Category c in categories)
                                            {
                                                if (c.Cname == ucat)
                                                {
                                                    Console.WriteLine("It already exists");
                                                    ccExist = true;
                                                    break;
                                                }
                                            }
                                            if (!ccExist)
                                            {
                                                Console.WriteLine("Adding the category");
                                                p.Category = ucat;
                                            }

                                            Console.Write("Enter New Description : ");
                                            p.description = Console.ReadLine();

                                            Console.Write("Enter New Price : ");
                                            p.price = Convert.ToInt32(Console.ReadLine());

                                            Console.Write("Enter New Quantity : ");
                                            p.quantity = Convert.ToInt32(Console.ReadLine());

                                            Console.Write("Enter New Brand : ");
                                            p.brand = Console.ReadLine();

                                            Console.Write("Enter New Discount : ");
                                            p.discount = Convert.ToSingle(Console.ReadLine());

                                            Console.Write("Enter New Rating : ");
                                            p.rating = Convert.ToSingle(Console.ReadLine());

                                            Console.WriteLine("Product Updated Successfully");
                                            break;
                                        }
                                    }

                                    if (!ufound)
                                    {
                                        Console.WriteLine("Product Id not found.");
                                    }

                                    break;


                                case 3:

                                    Console.Write("Enter Product Id to Delete : ");
                                    long did = Convert.ToInt64(Console.ReadLine());

                                    Product dpro = null;

                                    foreach (Product item in products)
                                    {
                                        if (item.Pid == did)
                                        {
                                            dpro = item;
                                            break;
                                        }
                                    }

                                    if (dpro != null)
                                    {
                                        products.Remove(dpro);
                                        Console.WriteLine("Product Deleted Successfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Product Id Not Found");
                                    }

                                    break;


                                case 4:

                                    Console.Write("Enter Product Id to Search : ");
                                    long sid = Convert.ToInt64(Console.ReadLine());

                                    bool check = false;

                                    foreach (Product obj in products)
                                    {
                                        if (obj.Pid == sid)
                                        {
                                            obj.display();
                                            check = true;
                                            break;
                                        }
                                    }

                                    if (check == false)
                                    {
                                        Console.WriteLine("Product Id Not Found");
                                    }

                                    break;


                                case 5:

                                    if (products.Count == 0)
                                    {
                                        Console.WriteLine("No Products Available");
                                    }
                                    else
                                    {
                                        foreach (Product p in products)
                                        {
                                            p.display();
                                            Console.WriteLine("----------------------------");
                                        }
                                    }

                                    break;

                                case 6:

                                    Console.Write("Enter Category Id : ");
                                    int cid = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Category Name : ");
                                    string cname = Console.ReadLine();


                                    bool present = false;
                                    bool nameExists = false;

                                    foreach (Category c in categories)
                                    {
                                        if (c.catId == cid)
                                        {
                                            present = true;
                                            break;
                                        }
                                        if (c.Cname.ToLower() == cname.ToLower())
                                        {
                                            nameExists = true;
                                        }

                                    }

                                    if (present)
                                    {
                                        Console.WriteLine("Category Id Already Exists");
                                        break;
                                    }
                                    if (nameExists)
                                    {
                                        Console.WriteLine("Name already exists");
                                        break;
                                    }



                                    Category categori = new Category(cid, cname);

                                    categories.Add(categori);

                                    Console.WriteLine("Category Added Successfully");

                                    break;



                                case 7:

                                    Console.Write("Enter Category Id to Delete : ");
                                    int id = Convert.ToInt32(Console.ReadLine());

                                    Category cat = null;

                                    foreach (Category c in categories)
                                    {
                                        if (c.catId == id)
                                        {
                                            cat = c;
                                            break;
                                        }
                                    }

                                    if (cat != null)
                                    {
                                        categories.Remove(cat);
                                        Console.WriteLine("Category Deleted Successfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Category Id Not Found");
                                    }

                                    break;
                                case 8:

                                    Console.Write("Enter Category Id to Update : ");
                                    int updateId = Convert.ToInt32(Console.ReadLine());

                                    bool isFound = false;

                                    foreach (Category ct in categories)
                                    {
                                        if (ct.catId == updateId)
                                        {
                                            isFound = true;

                                            Console.Write("Enter New Category Name : ");
                                            ct.Cname = Console.ReadLine();

                                            Console.WriteLine("Category Updated Successfully");
                                            break;
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        Console.WriteLine("Category Id Not Found");
                                    }

                                    break;

                            }
                            if (adminChoice == 9)
                            {
                                break;
                            }
                        }

                    }





                    else
                    {
                        Console.WriteLine("Invalid Admin Login");
                    }
                    break;





















































































































            }
        }
    }
}


//login
//update
//delete























