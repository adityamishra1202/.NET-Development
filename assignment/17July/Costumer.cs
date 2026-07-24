class Costumer
{
    List<Product> pros=new List<Product>();

    public long UserId;
    public string UserName;

    public string Name;
    public string Address;
    public string Password;

     public Costumer(long i,string u,string n,string a,string p)
    {
        UserId=i;
        UserName=u;
        Name=n;
        Address=a;
        Password=p;
    }
    
    public void logOut()
    {
         Console.WriteLine("Logged Out Successfully");

    }
    public void update(string u,string n,string a,string p)
    {
       UserName=u;
       Name=n;
       Address=a;
       Password =p;
}
public void Cpassword(string p)
    {
       Password=p; 
    }
    public void AddCart(long id,string name,string c,string d,int p,int q,string b,float dis,float rat)
    {
        Product pro=new Product(id,name,c,d,p,q,b,dis,rat);
        pros.Add(pro);
    }
    public void display()
    {
        foreach(Product p in pros)
        {
            p.display();
        }
    }
    public void delete(long id)
    {
        bool del=false;
        Product dpro=null;
        foreach(Product p in pros)
        {
            if (p.Pid == id)
            {
                dpro=p;
                del=true;
            }
        }
        if (del)
        {
            pros.Remove(dpro);
            Console.WriteLine("The item removed successfully");
        }
        if (!del)
        {
            Console.WriteLine("Id not exists");
        }
        
    }
    public void CartDisplay()
    {
        if (pros.Count == 0)
        {
            Console.WriteLine("First add the products in cart");
        }
        foreach(Product p in pros)
        {
            p.display();
        }
    }



    }