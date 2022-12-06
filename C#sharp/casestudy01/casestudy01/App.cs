using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy01
{
    class App : Info
    {
        public student[] studarray = new student[10];
        //Scenario-1
        public void Scenario1(bool student,bool Course)
        {
            if (student)
            {
                student st = new student(1, "Tejaswi", Convert.ToDateTime("02-01-2000"));
                studarray[0] = st;
                Console.WriteLine("Student data");
                Display(st);
            }
            if (Course)
            {
                Console.WriteLine("Course info");
                Course c = new Course(1, "Csharp", "6 Months", 20000);
                Display1(c);
            }
        }
        //Scenario-2
        public void Scenario2(bool student,bool Course)
        {
            if (student)
            {
                student[] std = new student[3];
                std[0] = new student(2, "Divya", Convert.ToDateTime("10-07-1999"));
                studarray[1] = std[0];
                std[1] = new student(3, "Haritha", Convert.ToDateTime("12-08-1998"));
                studarray[2] = std[1];
                std[2] = new student(4, "manasa", Convert.ToDateTime("9-09-1999"));
                studarray[3] = std[2];
                Console.WriteLine("Student information:");
                for (int i = 0; i < 3; ++i)
                {
                    Display(std[i]);
                }
            }
            if (Course)
            {
                Course[] cour = new Course[3];
                cour[0] = new Course(2, "java", "10 months", 40000);
                cour[1] = new Course(3, "SQL", "1 MONTH", 20000);
                cour[2] = new Course(4, "ADO.NET", "3 months", 30000);
                Console.WriteLine("Course Information:");
                for (int i = 0; i < 3; ++i)
                {
                    Display1(cour[i]);
                }
            }
        }
        //Scenario-3
        public void Scenario3(bool student,bool Course)
        {
            int j = 3;
            for (int i = 0; i < 3; i++)
            {
                if(student)
                {
                    Console.WriteLine("Enter student id,name, DOB :");
                    int id = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    DateTime dob = Convert.ToDateTime(Console.ReadLine());
                    student[] st = new student[3];
                    st[i] = new student(id, name, Convert.ToDateTime(dob));
                    studarray[j] = st[i];
                    Console.WriteLine("Student information:");
                    Display(st[i]);
                }
                if (Course)
                {
                    Console.WriteLine("enter the course id,Name,duration,fees");
                    int Cid = Convert.ToInt32(Console.ReadLine());
                    string cname = Console.ReadLine();
                    string cdur = Console.ReadLine();
                    double Cfee = Convert.ToDouble(Console.ReadLine());
                    Course[] c = new Course[3];
                    c[i] = new Course(Cid, cname, cdur, Cfee);
                    Console.WriteLine("Course Information:");
                    Display1(c[i]);
                }
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            App a = new App();
            // a.Scenario1();
            //  a.Scenario2();
            // a.Scenario3();


            AppEngine A = new AppEngine();
            //A.introduce();
            A.listOfStudents();
            //A.listofstudent();
            //A.listofcourse();
            //A.eroll(obj, s);
        }
    }
}


