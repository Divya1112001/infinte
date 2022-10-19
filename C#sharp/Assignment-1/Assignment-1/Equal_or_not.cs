//Write a C# Sharp program to accept two integers and check whether they are equal or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Equal_or_not
    {
        public static void Main()
        {
            Console.WriteLine("check whether two integers equal or not: \n");
            Console.WriteLine("--------------------------------------------");
            Console.Write("\n\n");

            int num1 = 5, num2 = 5;
            if (num1 == num2)
            {
                Console.WriteLine("num1 and num2 are equal\n", num1, num2);
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Console.ReadKey();
        }
    }
}
