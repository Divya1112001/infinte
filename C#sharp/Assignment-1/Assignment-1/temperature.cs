//Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class temperature
    {
        public static void Main ()
        {
            double celsius;
            double fahrenheit;
            Console.Write("Temperature in Fahrenheit :");
            fahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
            Console.ReadLine();
        }
    }
}
