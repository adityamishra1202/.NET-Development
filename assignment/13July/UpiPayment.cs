using System;

public class UpiPayment : PaymentGateway
{
    public  void ProcessPayment(int amount)
    {
        Console.WriteLine("Amount paid using UPI "+amount);
    }
}