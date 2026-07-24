using System;
class Question1
{
    public void process()
    {
        int qcr=0;
        int ps=0;
        int nr=0;
        int count=0;
        for(int id = 1001; id <= 1020; id++)
        {
            if (id % 4 == 0)
            {
                qcr=qcr+1;
            }
            else if (id % 5 == 0)
            {
                ps=ps+1;

            }
            else
            {
                nr=nr+1;
            }
            count=count+1;
        }
        Console.WriteLine("The packages processed: "+count);
        Console.WriteLine("Number of packages requiring quality check :"+qcr);
        Console.WriteLine("Number of packages requiring priority shipments :"+ps);
        Console.WriteLine("The number of normal packgea are :"+nr);
    }

}