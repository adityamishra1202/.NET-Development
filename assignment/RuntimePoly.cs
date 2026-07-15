using System;

public class RuntimePoly
{
    public void Checkout(PaymentGateway payment, int amount)
    {
        payment.ProcessPayment(amount);
    }
}