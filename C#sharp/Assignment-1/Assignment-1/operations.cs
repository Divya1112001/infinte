//Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,/) on them .
// To displays the result of that operation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class operations
    {
        static void Main(string[] args)
        {
            int x, y;
            char operation;

            Console.Write("Input first number: \n");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Wrong Character");
            Console.ReadLine();
        }
    }
}
