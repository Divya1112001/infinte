using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infinite.Casestudy1;


namespace Infinite.Casestudy2
{
    class Enroll
    {
        public LocalDate enrollmentDate { get; set; }
        public int CId { get; set; }
        public string CName { get; set; }
        public string Duration { get; set; }
        public double Fees { get; set; }
        public int Stuid { get; set; }
        public string Sname { get; set; }
        public string DOB { get; set; }

        public Enroll(int cId, string cName, string duration, double fees, int stuid, string sname, string dOB)
        {
            CId = cId;
            CName = cName;
            Duration = duration;
            Fees = fees;
            Stuid = stuid;
            Sname = sname;
            DOB = dOB;
        }




        //constructors & getters/setters
    }
    class AppEngine
    {
        Student[] s = new Student[3];
        Course[] c = new Course[3];
        Enroll[] E = new Enroll[3];
        public int id { get; set; }
        public string name { get; set; }
        public string duration { get; set; }
        public float fees { get; set; }
        public override string ToString()
        {
            return "courseid :" + id + "course name :" + name + "course duration:" + duration + " " + fees;
        }
        public void introduce()
        {
            Console.WriteLine("the new courses list");
            List<AppEngine> exam = new List<AppEngine>();
            exam.Add(new AppEngine() { id = 1, name = "hibernate", duration = "3months", fees = 7000 });
            exam.Add(new AppEngine() { id = 2, name = "angular", duration = "3months", fees = 6000 });
            exam.Add(new AppEngine() { id = 3, name = "jquery", duration = "3months", fees = 9000 });
            exam.Add(new AppEngine() { id = 4, name = "json", duration = "3months", fees = 8000 });
            exam.Add(new AppEngine() { id = 5, name = "datascience", duration = "3months", fees = 8000 });
            foreach (AppEngine e in exam)
            {
                Console.WriteLine(e);

            }


        }
        public void register()
        {
            Console.WriteLine("now we create a new user");
            string username, password = string.Empty;
            Console.WriteLine("Enter the username :");
            username = Console.ReadLine();
            Console.WriteLine("Enter the password");
            password = Console.ReadLine();
            Console.WriteLine("enter the name of the student");
            string student = Console.ReadLine();
            Console.WriteLine("enter the date of birth");
            string dateofbirth = Console.ReadLine();
            Console.WriteLine("enter the baranch of the student");
            string branch = Console.ReadLine();
            Console.WriteLine("enter the phone number");
            int phone = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter sw = new StreamWriter(File.Create("C:\\Csharp\\DotNetTraining\\Text")))
            {
                sw.Write(username);
                sw.Write(password);
                sw.Close();
            }
            Console.WriteLine("registration successfully");

        }
        public Student[] ListOfStudents()
        {
            Console.WriteLine("the list of students");

            Student[] se = new Student[3];
            se[0] = new Student(1, "ramya", "12/08/1998");
            se[1] = new Student(2, "neelima", "4/07/2000");
            se[2] = new Student(3, "anuhya", "4/06/20002");
            for (int i = 0; i < se.Length; i++)
            {
                //Console.WriteLine("enter the student id,student name,student date of birth");
                //int Stuid = Convert.ToInt32(Console.ReadLine());
                //string Sname = Console.ReadLine();
                //string  DOB = Console.ReadLine();
                //se[i] = new Student(s[i].Stuid,s[i].Sname,s[i].DOB.ToString())
                //{
                //    Stuid = s[i].Stuid,
                //    Sname = s[i].Sname,
                //    DOB = s[i].DOB.ToString(),
                //};
                Console.WriteLine(se[i].Stuid + se[i].Sname + se[i].DOB);
            }
            return se;

        }
        public Course[] listOfCourses()
        {
            Console.WriteLine("the list of courses");

            Course[] ce = new Course[3];
            ce[0] = new Course(1, "java", "2 months", 10000);
            ce[1] = new Course(2, "c++", "2 months", 10000);
            ce[2] = new Course(3, "Dotnet", "2 months", 10000);
            for (int i = 0; i < ce.Length; i++)
            {
                //Console.WriteLine("enter the course id ,course name,course duration,course fees");
                //int CId = Convert.ToInt32(Console.ReadLine());
                //string CName = Console.ReadLine();
                //string Duration = Console.ReadLine();
                //float Fees = float.Parse(Console.ReadLine());
                //ce[i] = new Course(c[i].CId, c[i].CName, c[i].Duration,c[i].Fees)
                //{
                //    CId = c[i].CId,
                //    CName = c[i].CName,
                //    Duration = c[i].Duration,
                //    Fees =c[i].Fees,
                //};
                Console.WriteLine(ce[i].CId + ce[i].CName + ce[i].Duration + ce[i].Fees);
            }
            return ce;
        }
        public void enroll()
        {
            Student[] stdlist = new Student[3];
            Course[] colist = new Course[3];
            // register();
            // introduce();
            stdlist = ListOfStudents();
            colist = listOfCourses();
            for (int i = 0; i < stdlist.Length; i++)
            {
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t{4}\t{5}\t{6}", stdlist[i].Stuid, stdlist[i].Sname, stdlist[i].DOB, colist[i].CId, colist[i].CName, colist[i].Duration, colist[i].Fees);
                int ids = stdlist[i].Stuid;
                string snm = stdlist[i].Sname;
                string DOB = stdlist[i].DOB;
                int id = colist[i].CId;
                string nm = colist[i].CName;
                string Dur = colist[i].Duration;
                double Fees = colist[i].Fees;

                E[i] = new Enroll(id, nm, Dur, Fees, ids, snm, DOB);
                {
                    int CId = id;
                    string CName = nm;
                    string Duration = Dur;
                    double fees = Fees;
                    int Stuid = ids;
                    string Sname = snm;
                    string dOb = DOB;
                };

            }
        }
        public Enroll[] listOfEnrollments()
        {

            Enroll[] EE = new Enroll[3];
            for (int i = 0; i < E.Length; i++)
            {
                EE[i] = new Enroll(E[i].CId, E[i].CName, E[i].Duration, E[i].Fees, E[i].Stuid, E[i].Sname, E[i].DOB)
                {
                    CId = E[i].CId,
                    CName = E[i].CName,
                    Duration = E[i].Duration,
                    Fees = E[i].Fees,
                    Stuid = E[i].Stuid,
                    Sname = E[i].Sname,
                    DOB = E[i].DOB,
                };
            }
            return EE;
        }
    }

}

