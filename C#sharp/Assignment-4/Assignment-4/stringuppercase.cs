//Create a Class Program which would be used to accepts two  Strings - FirstName and LastName and
//call the static method Display() that displays the first name in one line and the LastName in the second line after converting the same to upper case.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
        class stringuppercase
        {
            public void Display()
            {
                string FirstName, LastName;
                string str1, str2;
                Console.Write("Enter FirstName : ");
                FirstName = Console.ReadLine();
                Console.Write("Enter LastName : ");
                LastName = Console.ReadLine();
                str1 = FirstName.ToUpper();
                str2 = LastName.ToUpper();
                Console.WriteLine("Converted string is: " + str1);
                Console.WriteLine("Converted string is: " + str2);
                Console.Read();
            }
            public static void Main(string[] args)
            {
                stringuppercase p = new stringuppercase();
                p.Display();

            }
        }

    }

