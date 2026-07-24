using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
class StudentR
{

    public int Sid;
    public string Sname;
    public string Sdept;
    public string StudentType;
    public int TotalCredits = 0;
    List<CourseManage> l = new List<CourseManage>();



    public StudentR(int id, string name, string dept, string type)
    {
        Sid = id;
        Sname = name;
        Sdept = dept;
        StudentType = type;
    }
    public void display()
    {
        Console.WriteLine("The id of the student is " + Sid);
        Console.WriteLine("The name of the studenr is" + Sname);
        Console.WriteLine("The deprtment of thew student is" + Sdept);
        Console.WriteLine("Student Type : " + StudentType);
        Console.WriteLine("Total Credits : " + TotalCredits);
        Console.WriteLine("Total Fee : " + CalculateFee());
    }

    public void add(CourseManage course)
    {

        if (l.Count >= 3)
        {
            Console.WriteLine("Maximum courses reached.");
            return;
        }

        foreach (CourseManage c in l)
        {
            if (c.Cid == course.Cid)
            {
                Console.WriteLine("Already enrolled.");
                return;
            }
        }

        l.Add(course);
        TotalCredits += course.Credits;
        Console.WriteLine("Course enrolled successfully.");
    }

    public void enrolledcourses()
    {
        foreach (CourseManage core in l)
        {
            core.Show();
        }
    }

    public double CalculateFee()
    {
        double fee = 0;

        if (StudentType == "Regular")
            fee = TotalCredits * 1000;

        else if (StudentType == "Scholarship")
            fee = TotalCredits * 500;

        else if (StudentType == "Part-Time")
            fee = TotalCredits * 800;

        return fee;
    }


}
