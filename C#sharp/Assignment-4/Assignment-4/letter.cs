//Create a Program to count the no. of occurrences of a letter in a given string (for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class letter
    {
        static void Main(string[] args)
        {
            string str;
            char ch;
            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            Console.Write("Enter the Character");
            ch = Convert.ToChar(Console.ReadLine());
            int freq = 0;
            foreach (char c in str)
            {
                if (c == ch)
                {
                    freq++;
                }
            }
            Console.WriteLine(freq);
            Console.ReadLine();
        }
    }
}
