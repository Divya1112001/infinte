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
        void showStudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCoursesScreen();
        void LoginScreen();
    }

    public class StudentScreen : IStudent1
    {
        public void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
            }
        }
        public void ShowAdminScreen()
        {
            Console.WriteLine("now we create a new user");
            string username, password = string.Empty;
            Console.WriteLine("Enter the username :");
            username = Console.ReadLine();
            Console.WriteLine("Enter the password");
            password = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(File.Create("C:\\Tejaswi\\Training\\Csharp\\Text")))
            {
                sw.Write(username);
                sw.Write(password);
                sw.Close();
            }
            Console.WriteLine("Done");
            Console.WriteLine("Welcome to admin screen(Student Mgmt. System) v1.0");
            Console.WriteLine("these are details : \n1.Showstudentscreen\n2. showallstudentsscreen\n3. introducenewcourses\n4.showallcoursesscreen");
            Console.WriteLine("Enter your choice ( 1 or 2 or 3 or 4 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;

                case 2:
                    showAllStudentsScreen();
                    break;
                case 3:
                    introduceNewCourseScreen();
                    break;
                case 4:
                    showAllCoursesScreen();
                    break;
            }
        }
        public void showStudentScreen()
        {

            Console.WriteLine("Welcome to student(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Studentregistrationscreen\n2.LOGIN ");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    showStudentRegistrationScreen();
                    break;
                case 2:
                    LoginScreen();
                    break;
            }
        }
        public void LoginScreen()
        {

            Console.WriteLine("now we enter user");
            string username, password = string.Empty;
            Console.WriteLine("Enter the username :");
            username = Console.ReadLine();
            Console.WriteLine("Enter the password");
            password = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(File.Create("C:\\Csharp\\DotNetTraining\\text")))
            {
                sw.Write(username);
                sw.Write(password);
                sw.Close();
            }
            Console.WriteLine("LOGIN sUCCESSFULLY");

        }
        public void showStudentRegistrationScreen()
        {
            AppEngine a = new AppEngine();
            a.register();
        }
        public void showAllStudentsScreen()
        {
            App ae = new App();
            ae.Scenario2();
        }
        public void introduceNewCourseScreen()
        {
            AppEngine e = new AppEngine();
            e.introduce();
        }
        public void showAllCoursesScreen()
        {
            App ae = new App();
            ae.Scenario_2();
            AppEngine e = new AppEngine();
            e.introduce();
        }
    }
}

