//Write a program in C# to accept ten marks and display the following
  //a.Total
  //b.Average
  //c.Minimum marks
  //d. Maximum marks
  //e.Display marks in ascending order
  //f.Display marks in descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Array2
    {
        public static void Main ()
        {
            Array2 a = new Array2();
            a.totalavg();
            a.maxmin();
            a.ascendingdecendind();
        }

        public void totalavg()
        {
            int a, b, c, d, e, f, g, h, i, j, total, avg;
            Console.Write("Input  the marks of subject 1 : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of subject 2 : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of subject 3 : ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of subject 4 : ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of subject 5 : ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of subject 6 : ");
            f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of subject 7 : ");
            g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of subject 8 : ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of subject 9 : ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of subject 10 : ");
            j = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            total = a + b + c + d + e + f + g + h + i + j;
            avg = total / 10;
            Console.Write("Total Marks = {0}\nAverage = {1}\n", total, avg);
        }
        public void maxmin()
        {
            int[] arr = new int[10] { 91, 23, 13, 38, 57, 30, 67, 46, 68, 69 };
            int i, max, min, n;
            n = 10;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];

                }
            }
            Console.Write("Maximum element= {0}\n", max);
            Console.Write("Minimum element= {0}\n", min);
            Console.ReadLine();
        }

        public void ascendingdecendind()
        {
            int[] arr = new int[] { 81, 79, 46, 97, 55, 79, 81, 68, 95, 100 };

            Array.Sort(arr);
            Console.WriteLine("Ascending: ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            Array.Reverse(arr);
            Console.WriteLine("\n\nDescending: ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

        }

    }
}

