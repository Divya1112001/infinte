//Write a program in C# to accept a word from the user and display the length of it.
//Write a program in C# to accept a word from the user and display the reverse of it. 
//Write a program in C# to accept two words from user and find out if they are same. 
//Write a program in C# to accept a word and to find out whether the given word is a palindrome or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Strings
    {
        static void Main(string[] args)
        {
            Strings program = new Strings();
            program.palindrome();
            program.reverse();
            program.compare();
            program.length();
            Console.ReadLine();

        }

        public void palindrome()
        {
            string input, r;
            input = "Madam";
            char[] letter = input.ToCharArray();
            Array.Reverse(letter);
            r = new string(letter);
            bool bool1 = input.Equals(r, StringComparison.OrdinalIgnoreCase);
            if (bool1 == true)
            {
                Console.WriteLine("This string " + input + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine("This string " + input + " is not a Palindrome!");
            }
            Console.WriteLine("press Enter to continue ");
            Console.ReadLine();
        }
        public void reverse()
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
        public void compare()
        {
            string s1 = "man";
            string s2 = "man";
            bool result = string.Equals(s1, s2);
            Console.WriteLine(result);
        }
        public void length()
        {
            string s1 = "man";
            Console.WriteLine(" length of the word:" + s1.Length);
        }
    }
}

