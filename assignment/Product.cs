class Product
{
  public int ProductId;
  public string ProductName;
  public int Price;
  public int Stock;


  public Product(int pid,string pname,int price,int stock)
    {
        ProductId=pid;
        ProductName=pname;
        Price=price;
        Stock=stock;
        }
    public Product(int pid,string pname,int price)
    {
        ProductId=pid;
        ProductName=pname;
        Price=price;
    }   

     public void display()
    {


        Console.WriteLine("The id of the product is :"+ProductId);
        Console.WriteLine("The name of te product is:"+ProductName);
        Console.WriteLine("The price of the product is :"+Price);
        Console.WriteLine("The stock of the product is :"+Stock);

    }
    public void Adddisplay()
    {


        Console.WriteLine("The id of the product is :"+ProductId);
        Console.WriteLine("The name of te product is:"+ProductName);
        Console.WriteLine("The price of the product is :"+Price);
    

    }


















}