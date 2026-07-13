using System;
class CourseManage
{
    public int Cid;
    public string Cname;
    public int Credits;

    public CourseManage(int id, string name, int credit)
    {
        Cid = id;
        Cname = name;
        Credits = credit;
    }
    public void Show()
    {
        Console.WriteLine("The Course Id is " + Cid);
        Console.WriteLine("The Course Name is " + Cname);
        Console.WriteLine("Credits : " + Credits);
    }

}