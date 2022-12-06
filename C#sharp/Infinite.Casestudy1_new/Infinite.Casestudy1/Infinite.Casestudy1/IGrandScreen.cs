using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infinite.Casestudy1;
using Infinite.Casestudy2;

namespace Infinite.Casestudy3
{
    public interface IGrandScreen
    {
        void ShowFirstScreen();
        void showStudentScreen();
    }
    interface IStudent : IGrandScreen
    {
        void ShowAdminScreen();
        void showAllStudentsScreen();

    }
    interface IStudent1 : IStudent
    {
        void NewStudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCoursesScreen();
        void oldstudentScreen();

        void Enrollment();
        void listenrollment();
        void updatestudent();
    }

    public class StudentScreen : IStudent1
    {
        public void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin \n3. Exit");
            Console.WriteLine("Enter your choice ( 1 or 2 or 3) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                case 3:
                    Console.WriteLine("thank you");
                    break;
                default:
                    Console.WriteLine("invalid data");
                    Console.WriteLine("please choose valid options");
                    ShowFirstScreen();
                    break;


            }
        }
        public void Enrollment()
        {
            AppEngine a = new AppEngine();
            Console.WriteLine("the list of students");
            a.Selectstudents();
            Console.WriteLine("the list of courses");
            a.SelectCourses();
            Console.WriteLine("the enter the enrollment details");
            a.enroll();

        }

        public void listenrollment()
        {
            AppEngine a = new AppEngine();
            a.Selectenrollment();
            Console.WriteLine("Welcome to enrollment(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are :  \n1.updateenrollment \n2.Deleteenrollment");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    a.updateenrollment();
                    break;
                case 2:
                    a.deleteenrollment();
                    break;
                default:
                    Console.WriteLine("invalid data");
                    Console.WriteLine("please choose valid options");
                    listenrollment();
                    break;

            }
            ShowFirstScreen();

        }

        public void ShowAdminScreen()
        {
            Console.WriteLine("Welcome to admin screen(Student Mgmt. System) v1.0");
            Console.WriteLine("these are details : \n1. showallstudentsscreen\n2. introducenewcourses\n3.showallcoursesscreen  \n4.enrollment \n5.listof enrollments \n6. previous menu \n7. Exit");
            Console.WriteLine("Enter your choice ( 1 or 2 or 3 or 4 or 5 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {

                case 1:
                    showAllStudentsScreen();
                    break;
                case 2:
                    introduceNewCourseScreen();
                    break;
                case 3:
                    showAllCoursesScreen();
                    break;
                case 4:
                    Enrollment();
                    break;
                case 5:
                    listenrollment();
                    break;
                case 6:
                    ShowFirstScreen();
                    break;
                case 7:
                    Console.WriteLine("thankyou");
                    break;
                default:
                    Console.WriteLine("invalid data");
                    Console.WriteLine("please choose valid options");
                    ShowAdminScreen();
                    break;


            }

        }
        public void showStudentScreen()
        {

            Console.WriteLine("Welcome to student(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. NewStudentRegistraionScreen \n2.oldstudentScreen ");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    NewStudentRegistrationScreen();
                    break;
                case 2:
                    oldstudentScreen();
                    break;
                default:
                    Console.WriteLine("invalid data");
                    Console.WriteLine("please choose valid options");
                    showStudentScreen();
                    break;



            }
            ShowFirstScreen();
        }
        public void oldstudentScreen()
        {
            AppEngine app = new AppEngine();
            app.Selectstudents();

        }
        public void NewStudentRegistrationScreen()
        {
            AppEngine a = new AppEngine();
            a.register();

        }
        public void showAllStudentsScreen()
        {
            AppEngine app = new AppEngine();
            app.Selectstudents();
            Console.WriteLine("Welcome to student(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are :  \n1.updatestudent \n2.Deletestudent");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    updatestudent();
                    break;
                case 2:
                    AppEngine a = new AppEngine();
                    a.deletestudents();
                    break;
                default:
                    Console.WriteLine("invalid data");
                    Console.WriteLine("please choose valid options");
                    showAllStudentsScreen();
                    break;

            }
            ShowFirstScreen();
        }
        public void introduceNewCourseScreen()
        {
            AppEngine e = new AppEngine();
            Console.WriteLine("the  courses list");
            e.SelectCourses();
            e.introduce();

        }
        public void updatestudent()
        {
            AppEngine e = new AppEngine();
            e.updatestudents();
        }
        public void showAllCoursesScreen()
        {
            AppEngine app = new AppEngine();
            app.SelectCourses();
            Console.WriteLine("Welcome to  courses(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are :  \n1.updatecourse \n2.Deletecourse");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    app.updatecourses();
                    break;
                case 2:
                    app.deletecourse();
                    break;
                default:
                    Console.WriteLine("invalid data");
                    Console.WriteLine("please choose valid options");
                    showAllCoursesScreen();
                    break;

            }
            ShowFirstScreen(); ;
        }
    }
}
