class Order
{
    public int OrderId;
    public long CustomerId;
    public string Status;

    public Order(int oid,long cid,string s)
    {
        OrderId=oid;
        CustomerId=cid;
        Status=s;
    }

    public void display()
    {
        Console.WriteLine("Order Id : "+OrderId);
        Console.WriteLine("Customer Id : "+CustomerId);
        Console.WriteLine("Status : "+Status);
    }
}