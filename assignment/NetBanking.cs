using System;

public class NetBanking : PaymentGateway
{
    public  void ProcessPayment(int amount)
    {
        Console.WriteLine("Amount paid using Net Banking "+ amount);
    }
}