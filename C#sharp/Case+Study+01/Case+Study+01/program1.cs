using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_01
{
    class course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string Duration { get; set; }
        public double Fees { get; set; }

        course[] c = new course[3];

        public course[] Display()
        {
            course[] cour = new course[3];
            for (int i = 0; i < c.Length; i++)
            {
                cour[i] = new course()
                {
                    CId = c[i].CId,
                    CName = c[i].CName,
                    Duration = c[i].Duration,
                    Fees = c[i].Fees
                };
            }
            return cour;
        }
        public void accept_course()
        {
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Enter courseid,Name,duration,fees");
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                string dur = Console.ReadLine();
                double fee = Convert.ToDouble(Console.ReadLine());
                c[i] = new course()
                {
                    CId = id,
                    CName = name,
                    Duration = dur,
                    Fees = fee
                };
            }
        }

    }
    class Program1
    {
        static void Main(string[] args)
        {
            course cos = new course();
            course[] coslist = new course[3];

            cos.accept_course();
            coslist = cos.Display();
            for (int i = 0; i < coslist.Length; i++)
            {
                Console.WriteLine(coslist[i].CId + " " + coslist[i].CName + " " + coslist[i].Duration + " " + coslist[i].Fees);
            }
            Console.Read();
        }
    }
}
