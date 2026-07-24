using System;

class InvalidQuantityException : Exception
{
    public InvalidQuantityException()
        : base("Quantity should be greater than 0")
    {

    }
}