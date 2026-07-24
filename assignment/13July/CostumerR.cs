using System.Transactions;

public class CostumerR
{
    List<Product> produ=new List<Product>();
    public int Id;
    public string name;
    public string email;
    public string password;

    int sum=0;
    public CostumerR()
    {
        
    }

    public CostumerR(int i,string n,string e,string p)
    {
        Id=i;
        name=n;
        email=e;
        password=p;

    }
    
    // bool flag=true;
    // public void login(string mail,string pass)
    // {
    //     for(int count =1;count<=3;count++){
    //     if(email==mail && password == pass)
    //         {
    //             Console.WriteLine("Welcome {name}");
    //             flag=false;
    //         }
    //     }
    //     if (flag)
    //     {
    //         throw new Exception("Account Locked");
    //     }

   // }
   public void AddToCart(int id,string name,int price)
    {
        Product prod=new Product(id,name,price) ;
        produ.Add(prod);
        
    }
    public void AddedProducts()
    {
        foreach(Product p in produ)
        {
            p.Adddisplay();
        }
    }
    public int TotalAmount(){
        sum=0;
        foreach(Product p in produ)
        {
            sum+=p.Price;

        }
        return sum;
    }

    public int FinalAmount()
    {
        if(sum < 1000)
                    {
                        Console.WriteLine("No discount implied final Amount is");
                        return sum;
                    }
                    else if(sum>=1000 && sum<5000){
                        Console.WriteLine("10% discount is implied so final amount is");
                        return sum-(10*sum)/100;
                        
                    }
                    else if(sum>=5000 && sum<10000){
                        Console.WriteLine("20% discount is implied so final amount is");
                        return sum-((20*sum)/100);
                        
                    }
                    else
                    {
                       Console.WriteLine("30% discount is implied so final amount is");
                       return sum-((30*sum)/100);
                         
                    }
        
     }
     
     
   
   
   }