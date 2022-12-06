using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infinite.Casestudy2;
using Infinite.Casestudy3;
using Infinite.Casestudy4;

namespace Infinite.Casestudy1
{
    public class Student
    {
        public int Stuid { get; set; }
        public string Sname { get; set; }
        public string DOB { get; set; }

        public Student(int studentid, string name, string Dateofbirth)
        {
            Stuid = studentid;
            Sname = name;
            DOB = Dateofbirth;
        }

    }
    class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string Duration { get; set; }
        public double Fees { get; set; }
        public Course(int courseid, string cname, string coursedur, double coursefee)
        {
            CId = courseid;
            CName = cname;
            Duration = coursedur;
            Fees = coursefee;
        }
    }

    class Info
    {
        public void display(Student student)
        {
            Console.WriteLine("Name :" + student.Sname + '\n' + "Studnetid: " + student.Stuid + '\n' + "DateofBirth: " + student.DOB);
            Console.ReadLine();
        }

        public void display(Course course)
        {
            Console.WriteLine("CourseId :" + course.CId + '\n' + "CourseName: " + course.CName + '\n' + "CourseDuration: " + course.Duration + '\n' + "Course Fee" + course.Fees);
            Console.ReadLine();
        }
    }
    class App
    {

        public void Scenario1()
        {
            Student st = new Student(001, "Tejaswi", "02-01-2000");
            Course c = new Course(1, "Csharp", "6 Months", 20000);
            Console.WriteLine("Student data");
            Info In = new Info();
            In.display(st);
            Console.WriteLine("Course info");
            In.display(c);
        }
        public void Scenario2()
        {
            Student[] st = new Student[3];
            st[0] = new Student(1, "Divya", "10-07-1999");
            st[1] = new Student(2, "Haritha", "12-08-1998");
            st[2] = new Student(3, "Tejaswi", "9-09-1999");
            Console.WriteLine("Student information:");
            for (int i = 0; i < 3; ++i)
            {
                Info In = new Info();
                In.display(st[i]);
            }
        }
        public void Scenario_2()
        {
            Course[] c = new Course[3];
            c[0] = new Course(1, "C sharp", "6 months", 40000);
            c[1] = new Course(2, "SQL", "1 MONTH", 20000);
            c[2] = new Course(3, "ADO.NET", "3 months", 30000);
            Console.WriteLine("Course Information:");
            for (int i = 0; i < 3; ++i)
            {
                Info In = new Info();
                In.display(c[i]);
            }
        }
        public void Scenario3()
        {
            string[] studName = new string[20];
            int[] studNo = new int[20];
            string dateofbirth;
            string[] studcourse = new string[20];
            string[] courseduration = new string[20];
            float[] fees = new float[20];

            int n;
            Console.WriteLine("enter how many student data you want enter");
            n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter name of the student");
                studName[i] = Console.ReadLine();
                Console.WriteLine("enter the roll number student");
                studNo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the dateofbirth");
                //dateofbirth = Convert.ToDateTime(ToString());
                dateofbirth = Console.ReadLine();
                Console.WriteLine("enter the course of student");
                studcourse[i] = Console.ReadLine();
                Console.WriteLine("enter course duration");
                courseduration[i] = Console.ReadLine();
                Console.WriteLine("enter the course fees");
                fees[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("enter name of the student  :" + studName[i]);
                Console.WriteLine("enter  roll no of the student  :" + studNo[i]);
                Console.WriteLine("enter the date of birth :" + dateofbirth);
                Console.WriteLine("enter course of the student  :" + studcourse[i]);
                Console.WriteLine("enter course duration of student  :" + courseduration[i]);
                Console.WriteLine("enter the course of the fee  :" + fees[i]);


            }
            //for (int j = 0; j < n; j++)
            //{

            //    Console.WriteLine("enter name of the student  :" + studName[j]);
            //    Console.WriteLine("enter  roll no of the student  :" + studNo[j]);
            //    Console.WriteLine("enter the date of birth :"+dateofbirth);
            //    Console.WriteLine("enter course of the student  :" +studcourse[j]);
            //    Console.WriteLine("enter course duration of student  :" + courseduration[j]);
            //    Console.WriteLine("enter the course of the fee  :" + fees[j]);


            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter student id,name, DOB :");
            //    int id = Convert.ToInt32(Console.ReadLine());
            //    string name = Console.ReadLine();
            //    string dob = Console.ReadLine();

            //    Console.WriteLine("enter the course id,Name,duration,fees");
            //    int Cid = Convert.ToInt32(Console.ReadLine());
            //    string cname = Console.ReadLine();
            //    string cdur = Console.ReadLine();
            //    double Cfee = Convert.ToDouble(Console.ReadLine());

            //    Student[] st = new Student[3];
            //    st[i] = new Student(id, name, dob);
            //    Course[] c = new Course[3];
            //    c[i] = new Course(Cid, cname, cdur, Cfee);
            //    Console.WriteLine("Student information:");
            //    Info In = new Info();
            //    In.display(st[i]);
            //    Console.WriteLine("Course Information:");
            //    In.display(c[i]);
            //}
        }
        static void Main(string[] args)
        {

            App app = new App();
            //app.Scenario1();
            //app.Scenario2();
            //app.Scenario_2();
            // app.Scenario3();
            // app.display(enroll);

            AppEngine std = new AppEngine();
            // Enroll[] EElist = new Enroll[3];
            //std.listOfCourses();
            //std.enroll();
            //EElist = std.listOfEnrollments();

            //for (int i = 0; i < EElist.Length; i++)
            //{
            //    Console.WriteLine(EElist[i].Stuid + EElist[i].Sname + EElist[i].DOB + EElist[i].CId + EElist[i].CName + EElist[i].Duration + EElist[i].Fees);
            //}

            //StudentScreen st = new StudentScreen();
            //st.ShowFirstScreen();


            Connection1 I1 = new Connection1();
            I1.std();
            // I1.cour();

            Console.Read();

        }
    }

}


