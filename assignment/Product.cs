// Product Id
// Name
// Category
// Description
// Price
// Quantity
// Brand
// Discount
// Rating
class Product
{
   public long Pid;
   public string Pname;
   public string Category;
   public string description;
   public int price;
   public int quantity;
   public string brand ;

   public float discount;
   public float rating;

public Product(long id,string name,string c,string d,int p,int q,string b,float dis,float rate)
    { Pid=id;
   Pname=name;
   Category=c;
   description=d;
    price=p;
    quantity=q;
    brand=b;

   discount=dis;
    rating=rate;

}
public void display()
    {
        Console.WriteLine("The id of the product is "+Pid);
        Console.WriteLine("The name of the product is "+Pname);
        Console.WriteLine("The category of the product is "+Category);
        Console.WriteLine("The description of the product is "+description);
        Console.WriteLine("The price of the product is "+price);
        Console.WriteLine("The quantity of the product is "+quantity);
        Console.WriteLine("The brand of the product is "+brand);
        Console.WriteLine("The discount of the product is "+discount);
        Console.WriteLine("The rating of the product is "+rating);
    
    }



























}