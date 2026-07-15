using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Transactions;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        List<CostumerR> costumers=new List<CostumerR>();
        List<Product> products=new List<Product>();


        while (true)
        {    
            Console.WriteLine("1.Register a Consumer:");
            Console.WriteLine("2.Log in to the app:");
            Console.WriteLine("3.Display the costumers");
            Console.WriteLine("4.For adding the products:");
            Console.WriteLine("5.Display the products");
            Console.WriteLine("6.Search the product:");
            Console.WriteLine("7.Adding the products to cart");
            Console.WriteLine("8.Display the added products");
            Console.WriteLine("9.Display the total amount and final amount");
            Console.WriteLine("10.Choosing the Payment type and paying amount \n 1.UpiPayment \n 2.NetBanking \n  3.CreditCard");
            Console.WriteLine("11.Exit");
            Console.Write("Enter Choice 1-11: ");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                 Console.Write("Enter id : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        bool exists = false;

                        foreach (CostumerR con in costumers)
                        {
                            if (con.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Costumer id already exists");
                            break;
                        }
                        Console.Write("Enter costumer name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter email:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter the password");
                        string pass=Console.ReadLine();
                        CostumerR costumer = new CostumerR(id, name,email,pass );
                        costumers.Add(costumer);
                        Console.WriteLine("Costumer Added successfully");
                        break;
                case 2:
                bool log=false;
                string coname="Unknown";
                for(int count=1;count<=3;count++){
                Console.WriteLine("Enter the eamil for the login");
                string log_email=Console.ReadLine();
                Console.WriteLine("Enter the password");
                string log_pass=Console.ReadLine();
                foreach(CostumerR con in costumers)
                        {
                            if(con.password==log_pass && con.email == log_email)
                            {
                             log=true;
                            coname=con.name;
                             break;
                            }
                        }
                
                    if (log)
                    {
                        Console.WriteLine("Welcome "+coname);
                        break;
                    }
                        if (count == 3)
                        {   
                            Console.WriteLine("Account Locked");
                            break;
                        }
                }
                break;
                case 3:
            
                     
                    
                        if (costumers.Count == 0)
                        {
                            Console.WriteLine("No added products");
                        }
                        foreach(CostumerR con  in costumers)
                    {
                        Console.WriteLine("The id is"+con.Id);
                        Console.WriteLine("The name is:"+con.name);
                    }
                     break;



                case 4:
                Console.WriteLine("enter the nunmber of products you want to add");
                int num=Convert.ToInt32(Console.ReadLine());
                for(int i = 1; i <= num; i++)
                    {
                        Console.WriteLine("give the id for the " +i+" product");
                         int pid=Convert.ToInt32(Console.ReadLine());
                         foreach(Product pro in products)
                        {
                            if (pro.ProductId == pid)
                            {
                                Console.WriteLine("This id already exists");
                                break;
                            }
                            }
                         Console.WriteLine("Enter product name") ;  
                        string pname=Console.ReadLine();
                        Console.WriteLine("Enter the price");
                        int pprice=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the stock");
                        int pstock=Convert.ToInt32(Console.ReadLine());
                        Product product=new Product(pid,pname,pprice,pstock);
                        products.Add(product);
                    } 
                    Console.WriteLine("=================");
                        break;
                        case 5:
                     
                    
                        if (products.Count == 0)
                        {
                            Console.WriteLine("No added products");
                        }
                        foreach(Product pr in products)
                    {
                        pr.display();
                    }
                     break;

                     case 6:
                     bool enter=false;
                     Console.WriteLine("Enter the product name to search:");
                     int searchName=Convert.ToInt32(Console.ReadLine());
                     foreach(Product pro in products)
                    {
                        if (searchName == pro.ProductId)
                        {
                            Console.WriteLine("Yes product is present");
                            pro.display();
                            enter=true;
                            break;
                        }

                    }
                    if (!enter)
                    {
                        Console.WriteLine("No its not present \n");
                    }

                     break; 
                     
        
                     case 7:
                     Console.WriteLine("Enetr the id of the costumer");
                     int Cid=Convert.ToInt32(Console.ReadLine());
                     foreach(CostumerR con in costumers){
                        if(con.Id==Cid){
                     Console.WriteLine("Enetr the id of the product you want to add");
                     int AddId= Convert.ToInt32(Console.ReadLine())  ;
                     foreach(Product pr in products)
                    {
                        if (pr.ProductId == AddId)
                        {
                            Console.WriteLine("Enter the stock"+pr.Stock);
                            con.AddToCart(AddId,pr.ProductName,pr.Price);
                        }
                    }   
                        }        

            }      
                     break;
                     case 8:
                     Console.WriteLine("Enter the Id of the costumer you want to see added products");
                     int coId=Convert.ToInt32(Console.ReadLine());
                     foreach(CostumerR con in costumers)
                    {
                        if(coId==con.Id){
                       con.AddedProducts() ;
                        }
                    }
                    break;
                    case 9:
                    Console.WriteLine("Enter the Id of the costumer you want to see the total payment");
                    int sum=0;
                     int payId=Convert.ToInt32(Console.ReadLine());
                     foreach(CostumerR con in costumers)
                    {
                        if(payId==con.Id){
                       Console.WriteLine("The total amount is"+con.TotalAmount());
                       Console.WriteLine("The final amout is:" +con.FinalAmount());
                        }
                    }
                 
                    break;
                    case 10:
                    bool fly=false;
                    Console.WriteLine("Enter the id for the mode in which you want to pay money");
                    int TypepayId=Convert.ToInt32(Console.ReadLine());
                    foreach(CostumerR con in costumers){
                        if (TypepayId == con.Id)
                        {
                            Console.WriteLine("enter the choice");
                            int choic=Convert.ToInt32(Console.ReadLine());
                            switch (choic)
                            {
                                case 1:
                                RuntimePoly r=new RuntimePoly();
                                r.Checkout(new UpiPayment(),con.FinalAmount());
                                break;
                                case 2:
                                RuntimePoly r1=new RuntimePoly();
                                r1.Checkout(new NetBanking(),con.FinalAmount());
                                break;
                                case 3:
                                RuntimePoly r2=new RuntimePoly();
                                r2.Checkout(new UpiPayment(),con.FinalAmount());
                                break;
                                default:
                                Console.WriteLine("Not entered valid one");
                                break;


                         }
                         fly=true;
                        }
                    }
                        if (!fly)
                        {
                            Console.WriteLine("Id enetred wrongly no such id exists");
                        }
                         break;
                    case 11:
                     return;  
                    //   default:
                    //   Console.WriteLine("entered Wrongly")  ;
                    //   break;
                    

}
                

}

}
}

