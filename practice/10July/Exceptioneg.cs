using System;

class Exceptioneg
{  
    
    public void Example(){
    try{
        int a=1000;
        int b=40;
        int c=(a /b) ;
        Console.WriteLine  (c)  ;
        
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

    



    }

}