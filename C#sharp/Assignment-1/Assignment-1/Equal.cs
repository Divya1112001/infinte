//Write a C# Sharp program to check whether a given number is positive or negative.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class positiveornot
    {
        static void Main()
        {


            int n;
            Console.WriteLine("Input 1st number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            // checking for positive, negative or 0
            if (n < 0)
            {
                Console.WriteLine("Negative Number!");
            }
            else if (n == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Positive Number!");
            }
            Console.Read();
        
        }
    }
}
