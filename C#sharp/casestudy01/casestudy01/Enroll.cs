using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy01
{
    class Enroll
    {
        private student student;
        private Course course;
        private LocalDate enrollmentDate;
        public string students
        {
           get { return students;}
           set {  students = value;}
         }
        public string courses
        {
            get { return courses; }
            set { courses = value; }
        }
        public string enrollmentDates
        {
            get { return enrollmentDates; }
            set { enrollmentDates = value; }
        }
        public Enroll (string studentname, string coursename, LocalData EnrollmentDate)
        {
            students = studentname;
            courses = coursename;
          //  EnrollmentDate = EnrollmentDate;
           }
    }
}
