using System;

class InsufficientStockException : Exception
{
    public InsufficientStockException()
        : base("Insufficient Stock")
    {

    }
}