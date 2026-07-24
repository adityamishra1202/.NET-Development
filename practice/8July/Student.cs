using System;

class Student
{
    public String name;
     public String institute;
    public long dob;
     public String branch;
     public char gender;
    public float height;
    public Student(String n,String i,long d,String b,char g,float h)
    {
        name=n;
        institute=i;
        dob=d;
        branch=b;
        gender=g;
        height=h;
    }
public void display()
    {
      Console.WriteLine(name+" "+institute+" "+dob+" "+ branch+" "+gender+" "+height) ; 
    }

}