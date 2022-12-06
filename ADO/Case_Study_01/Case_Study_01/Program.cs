using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_01
{
    class student
    {
        public int stdid { get; set; }
        public string stdname { get; set; }
        public float marks { get; set; }
        student[] s = new student[3];

        public student[] Display()
        {
            student[] sres = new student[3];
            for (int i = 0; i < s.Length; i++)
            {
                sres[i] = new student()
                {
                    stdid = s[i].stdid,
                    stdname = s[i].stdname,
                    marks = s[i].marks,
                };
            }
            return sres;
        }
        public void accept_student()
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter Stdid, Stdname,Stdmarks");
                int id = Convert.ToInt32(Console.ReadLine());
                string nm = Console.ReadLine();
                float mks = float.Parse(Console.ReadLine());
                s[i] = new student()
                {
                    stdid = id,
                    stdname = nm,
                    marks = mks,
                };
            }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            student[] stdlist = new student[3];

            std.accept_student();
            stdlist = std.Display();
            for (int i = 0; i < stdlist.Length; i++)
            {
                Console.WriteLine(stdlist[i].stdid + stdlist[i].stdname + stdlist[i].marks);
            }
            Console.Read();
        }
    }
}
