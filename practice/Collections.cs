using System;
//Collections:That can grow or shrink
//more flexible than array
using System.Collections.Generic;

//list:dynamic array
//dictionaries
class Collections
{
    public void arr(){
        List<String> names=new List<String>();
        names.Add("Dev");
        names.Add("Abhiram");
        names.Add("Ajay");
        foreach (String n in names)
        {
            Console.WriteLine(n);
        }
    
    }

}