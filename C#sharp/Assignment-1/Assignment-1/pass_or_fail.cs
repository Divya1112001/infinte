//Write a program which accepts marks of 5 students for C#,HTML and Sql (3 subjects),calculates the average and prints result as passed or failed
//If avg< 50 then failed else passed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class pass_or_fail
    {
        public static void Main ()
        {
            double rl, tel, math, eng, total;
            double avg;
            string nm, res;

            Console.Write("\n\n");
            Console.Write("Calculate the total, Average and result to take marks of three subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the Roll Number of the student :");
            rl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student :");
            nm = Console.ReadLine();

            Console.Write("Input  the marks of telugu : ");
            tel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  maths : ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of English : ");
            eng = Convert.ToInt32(Console.ReadLine());

            total = tel + math + eng;
            avg = total / 3.0;
            if (avg >= 36)
                res = "Pass";
            else
                res = "Fail";

            Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
            Console.Write("Marks in telugu : {0}\nMarks in maths : {1}\nMarks in english : {2}\n", tel, math, eng);
            Console.Write("Total Marks = {0}\nAverage = {1}\nresult = {2}\n", total, avg, res);
            Console.Read();
        }
    }
}
