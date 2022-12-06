using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy01
{
    class AppEngine : App
    {
        student[] std1 = new student[1];
        student[] student;
        Course[] course;
        Enroll[] enroll;
        public void introduce(Course course)
        {
            Course[] cs = new Course[1];
           // Course cs = new Course(5, "Javascript", "11 Months", 70000);
            Display1(cs[0]);
        }

        public void register(student student)
        {
            student[] std1 = new student[1];
            std1[0] = new student(5, "manasa", Convert.ToDateTime("01/29/2000"));
            Display(std1[0]);
        }
        public student[] listOfStudents()
        {
            
            App a = new App();
            a.Scenario1(true,false);
            a.Scenario2(true, false);
            a.Scenario3(true, false);
            Console.WriteLine("list of students");
            AppEngine a1 = new AppEngine();
            a1.register(std1[0]);
            return std1 ;
        }
       //// public Course[] listOfCourses()
       // {
       //     App a = new App();
       //     a.Scenario1(true, false);
       //     a.Scenario2(true, false);
       //     a.Scenario3(true, false);
       //     Console.WriteLine("list of Course");
       //     AppEngine a1 = new AppEngine();
       //    // a1.introduce(cs[0]);
       //    // return cs;
       // }
    }
}
