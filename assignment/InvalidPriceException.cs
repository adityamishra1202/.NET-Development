using System;

class InvalidPriceException : Exception
{
    public InvalidPriceException()
        : base("Price should be greater than 0")
    {

    }
}