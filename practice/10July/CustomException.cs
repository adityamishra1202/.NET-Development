using System;

class CustomException
{
    static void CheckAge(int age)
    {
        if (age < 20)
        {
            throw new InvalidAgeException("Age should be above 20 for getting driving license");
        }

        Console.WriteLine("Age is 20 and above, eligible for drive");
    }

    public void Handle()
    {
        try
        {
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());

            CheckAge(age);
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter an integer.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }

        
    }
}