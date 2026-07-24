using System;
  

class LambdaExpression
{
    public void Purpose()
    {
        // Lambda expression - shorter way to write anonymous functions
        // (parameters) => expression

        Func<int, int> square = x => x * x;
        Console.WriteLine(square(6));   // 36

        Func<int, int, int> subb = (a, b) => a - b;
        Console.WriteLine(subb(10, 50));   // -40

        // Without Lambda
           // 30
    }


}