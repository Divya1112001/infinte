//Write a  Program to assign integer to an array  and then print the following
    //a.Average value of Array elements
    //b.Minimum and Maximum value in an array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Array1
    {
        public static void Main ()
        {
            Array1 p = new Array1();
            p.array();
            p.maxmin();
            Console.Read();
        }

        public void array()
        {
            int[] arr = { 1, 8, 21, 36, 58, 67 };

            int i, sum = 0;
            float average = 0.0F;
            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            average = sum / arr.Length;
            Console.WriteLine("Average of array elements:" + average);
            Console.ReadLine();

        }
        public void maxmin()
        {
            int[] arr = new int[6] { 91, 23, 13, 8, 57, 30 };
            int i, max, min, n;
            n = 6;
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
    }
}

