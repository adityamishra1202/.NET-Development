using System.IO.Compression;

class Program
{
    static void Main()
    {

        List<StudentR> students = new List<StudentR>();
        List<CourseManage> courses = new List<CourseManage>();
        while (true)
        {
            Console.WriteLine("1.Add a Student");
            Console.WriteLine("2.Display the registered students");
            Console.WriteLine("3.Add The Course");
            Console.WriteLine("4.View All courses");
            Console.WriteLine("5.Enroll for the course");
            Console.WriteLine("6.Search Student");
            Console.WriteLine("8.Exit");
            Console.WriteLine("7.View Student details");
            Console.WriteLine("Enter choice 1-8");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    bool enter = false;
                    foreach (StudentR stu in students)
                    {
                        if (stu.Sid == id)
                        {
                            enter = true;
                            break;
                        }
                    }
                    if (enter)
                    {
                        Console.WriteLine("Student Already Registered");
                        break;
                    }
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Student Type (Regular/Scholarship/Part-Time): ");
                    string type = Console.ReadLine();


                    Console.Write("Enter the department: ");
                    string dept = Console.ReadLine();
                    StudentR student = new StudentR(id, name, dept, type);
                    students.Add(student);
                    break;

                case 2:
                    if (students.Count == 0)
                    {
                        break;
                    }
                    foreach (StudentR stu in students)
                    {
                        stu.display();
                    }
                    break;
                case 3:
                    Console.Write("Enter the course id:");
                    int iid = Convert.ToInt32(Console.ReadLine());
                    bool entry = false;
                    foreach (CourseManage cm in courses)
                    {
                        if (cm.Cid == iid)
                        {
                            entry = true;
                            break;
                        }
                    }
                    if (entry)
                    {
                        Console.WriteLine("Course Already Registered");
                        break;
                    }
                    Console.Write("Enter course name: ");
                    string Cname = Console.ReadLine();
                    Console.Write("Enter Credits : ");
                    int credit = Convert.ToInt32(Console.ReadLine());

                    CourseManage course = new CourseManage(iid, Cname, credit);

                    courses.Add(course);
                    break;
                case 4:

                    if (courses.Count == 0)
                    {
                        break;
                    }
                    foreach (CourseManage cm in courses)
                    {
                        cm.Show();
                    }
                    break;

                case 5:

                    Console.Write("Enter Student ID: ");
                    int ssid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Course ID: ");
                    int cid = Convert.ToInt32(Console.ReadLine());

                    bool studentFound = false;
                    bool courseFound = false;

                    foreach (StudentR stu in students)
                    {
                        if (stu.Sid == ssid)
                        {
                            studentFound = true;

                            foreach (CourseManage cm in courses)
                            {
                                if (cm.Cid == cid)
                                {
                                    courseFound = true;
                                    stu.add(cm);
                                    break;
                                }
                            }

                            if (!courseFound)
                            {
                                Console.WriteLine("Course not found.");
                            }

                            break;
                        }
                    }

                    if (!studentFound)
                    {
                        Console.WriteLine("Student not found.");
                    }

                    break;


                case 6:
                    Console.Write("Enter Student ID : ");
                    int sid = Convert.ToInt32(Console.ReadLine());

                    bool found = false;

                    foreach (StudentR s in students)
                    {
                        if (s.Sid == sid)
                        {
                            s.display();
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        Console.WriteLine("Student not found.");
                    break;


                case 7:
                    Console.Write("Enter Student ID : ");
                    int sssid = Convert.ToInt32(Console.ReadLine());

                    foreach (StudentR s in students)
                    {
                        if (s.Sid == sssid)
                        {
                            s.display();

                            Console.WriteLine("Enrolled Courses");

                            s.enrolledcourses();

                            Console.WriteLine("Total Credits : " + s.TotalCredits);

                            Console.WriteLine("Fee : " + s.CalculateFee());

                            break;
                        }

                    }
                    break;
                case 8:
                    return;













            }






        }

    }

}
