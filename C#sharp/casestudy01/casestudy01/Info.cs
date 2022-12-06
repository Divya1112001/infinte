using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy01
{
    class Info
    {
        public void Display(student student)
        {
            Console.WriteLine("Studnetid: " + student.stdid + '\n'+ "Name :" + student.stdname + '\n'+ "DateofBirth: " + student.dob);
            Console.ReadLine();
        }
        public void Display1(Course course)
        {
            Console.WriteLine("CourseId :" + course.CId + '\n' + "CourseName: " + course.CName + '\n' + "CourseDuration: " + course.Duration + '\n' + "Course Fee" + course.Fees);
            Console.ReadLine();
        }
        //public void Display2(Enroll enroll)
        //{
        //    Console.WriteLine("studentname :" + enroll.students + '\n' + " coursename :" + enroll.courses + '\n' + "EnrollmentDate : " + enroll.EnrollmentDate);
        //    Console.ReadLine();
        //}
    }
}