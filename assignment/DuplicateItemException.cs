using System;

class DuplicateItemException : Exception
{
    public DuplicateItemException()
        : base("Item Id already exists")
    {

    }
}