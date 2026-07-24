using System;

public interface PaymentGateway
{
    void ProcessPayment(int amount);
}