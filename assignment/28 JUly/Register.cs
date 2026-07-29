using _28_July_Assign.Models;


namespace _28_July_Assign.Services
{
    public class Register: IRegistration
    {
        private static List<Course> courses = new List<Course>() { 
        
        new Course{Id=100,Title="DSGT",Credits=2,duration=1},
         new Course{Id=101,Title="OOP",Credits=1,duration=1},
          new Course{Id=102,Title="ADE",Credits=2,duration=5},
          new Course{Id=103,Title="DE",Credits=2,duration=2}



   };
        






       public  List<Course> DisplayCourse()
        {
            return (courses);
        }

       public Course UpdateCourse(int id, Course cs)
        {

            var existing=courses.FirstOrDefault(c => c.Id == id);
            
            existing.duration=cs.duration;
            return existing;
        }

       public Course RegisterCourse( Course course)
        {

           
            
            courses.Add(course);
            return course;
        }

        public bool CancelCourse(int id)
        {   
            
            var existing = courses.FirstOrDefault(c => c.Id == id);
            if (existing == null) return false;         
            courses.Remove(existing);
            return true;    


        }
      





    }
}
