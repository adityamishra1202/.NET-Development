class Payment
{
    public int PaymentId;
    public int OrderId;
    public int Amount;
    public string Mode;
    public string Status;

    public Payment(int pid,int oid,int amt,string m,string s)
    {
        PaymentId=pid;
        OrderId=oid;
        Amount=amt;
        Mode=m;
        Status=s;
    }

    public void display()
    {
        Console.WriteLine("Payment Id : "+PaymentId);
        Console.WriteLine("Order Id : "+OrderId);
        Console.WriteLine("Amount : "+Amount);
        Console.WriteLine("Payment Mode : "+Mode);
        Console.WriteLine("Status : "+Status);
    }
}