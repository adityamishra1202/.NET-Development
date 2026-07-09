// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(){
    
        Student st=new Student("Charan","IIT",12022001,"Electronics",'M',190.23f);
        // st.name="Hariom";
        // st.institute="IIT";
        // st.branch="Electronics";
        // st.dob=12022007;
        // st.gender='M';
        // st.height=189.6f;
        
        st.display();
        Console.WriteLine("\n");

        int[]arr=new int[3];
        arr[0]=23;
        arr[1]=11;
        arr[2]=111;
        foreach(int elements in arr)
        {
        Console.WriteLine(elements);
        }
        Console.WriteLine("\n \n");
        
        
        Collections c=new Collections();
        c.arr();
    
        Question1 q1=new Question1();
        q1.company();
        

        Question2 q2=new Question2();
        q2.library();
}
    }

