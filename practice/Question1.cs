class Question1
{
    public void company()
    {
        int sum=0;
        
        int[] sale = new int[6];
        sale[0] = 72340;
        sale[1] = 50000;

        sale[2] = 99000;
        sale[3] = 72390;
        sale[4] = 77000;
        sale[5] = 44000;
        foreach(int s in sale)
        {   Console.WriteLine(s);
            sum+=s;
        }
        int lowest=sale[0];
        for(int i = 0; i <= 5; i++)
        {
            if (sale[i] < lowest)
            {
                lowest=sale[i];
            }
        }
        Console.WriteLine("\n");
        int highest=sale[0];
        for(int i = 0; i <= 5; i++)
        {
            if (sale[i]>highest)
            {
                highest=sale[i];
            }
        }
        Console.WriteLine("The total sale is :"+sum+"\n");
        Console.WriteLine("The average sale is:"+sum/6);
        Console.WriteLine("The highest sale is:"+highest);
        Console.WriteLine("The lowest sale is:"+lowest);


    }

}