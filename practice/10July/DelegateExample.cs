
//type that holds the reference to a method
//similar to function pointer

using System;
using System.Linq;

// Delegate - type that holds a reference to a method
// Similar to a function pointer
// Func - returns a value

// Built-in delegate (Func)


// Custom delegate

// Func<int, int, int> add = (a, b) => a + b;
//          Console.WriteLine(add(588, 756));
        
delegate void MessageDelegate(string msg);

        
class DelegateExample
{   
    static MessageDelegate m;
    static void Enterage(int age)
    {
        if (age < 20)
        {
            throw new Exception("Invalid age");
        }
    Console.WriteLine("You are eligible");
        
    }
    static void Display(string message)
    {
        Console.WriteLine("Method: "+message);
    }
        static void Display1(string message)
    {
        Console.WriteLine("Method 1" +message);
    }
        static void Display2(string message)
    {
        Console.WriteLine("Method 3" +message);
    }


    static void Main()
    {   
         Func<int, int, int> add = (a, b) => a + b;
         Console.WriteLine(add(588, 756));
        
        // MessageDelegate m = Display;
        m=Display;
        m+=Display1;
        m+=Display2;
        m("Hello, I am learning .NET C#");

       LambdaExpression  d=new LambdaExpression();
       d.Purpose();
    

Console.WriteLine("\n \n \n");

    
        int[] numbers = { 8, 7, 6, 4, 1, 8, 7, 8, 3, 9 };

        var even = numbers.Where(x => x % 2 == 0);

        foreach (var n in even)
        {
            Console.WriteLine(n);
        }
Exceptioneg eg=new Exceptioneg();
eg.Example();


        try
        {
            Enterage(111);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }



        CustomException c=new CustomException();
        c.Handle();
    
}
    
}