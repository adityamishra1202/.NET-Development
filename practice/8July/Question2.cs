using System.Diagnostics.Tracing;
using System.Numerics;
using System.Runtime.Serialization.Formatters;

class Question2
{
    public void rate()
    {
        int power=0;
        int total=0;
        int mr=0;
        int no=0;
        int ef=0;
        for (int count = 1; count <= 30; count++)
        {
            power=80+(count*5);
            if (power > 180)
            {
                Console.WriteLine("Maintenance Required");
                mr=mr+1;
            }
            else if(power>=140 && power <= 180)
            {
                Console.WriteLine("Normal Operation");
                no=no+1;
            }
            else
            {
                Console.WriteLine("Energy Efficient");
                ef=ef+1;
            }
            total=total+power;
        }
Console.WriteLine("Total power required is: " + total);
Console.WriteLine("Average Power Consumption is :"+total/30);
Console.WriteLine("Number of lights for maintennce: "+mr);
Console.WriteLine("Number of lights for normal operation :"+no);
Console.WriteLine("Lights which are energy efficient :"+ef);

}
}