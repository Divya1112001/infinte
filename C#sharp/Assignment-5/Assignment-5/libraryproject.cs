//I.  Create a class library Project called Concession. Write a method called CalculateConcession(int age)  that takes age as an input and calculates concession for travel as below:
//If age<=5 then “Little Champs- Free Ticket” should be displayed
//If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500/-) and Display “ Senior Citizen” + Calculated Fare
//Else “Print Ticket Booked” + Fare.
//II.Create a Console application with a Class called Program which has int TotalFare as Constant, Name, Age.Accept Name, Age from the user and call the CalculateConcession() function

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class libraryproject
    {
        public void CalculateConcession()
        {
            string Name;
            Console.WriteLine("Enter a Name");
            Name = Convert.ToString(Console.ReadLine());
            int AgeOfPassanger;
            double TotalFare = 500;
            Console.WriteLine("Enter  age");
            AgeOfPassanger = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < AgeOfPassanger; i++)
            {
                if (AgeOfPassanger <= 5)
                {
                    Console.WriteLine("Little Champs- Free Ticket");

                }
                else
                if (AgeOfPassanger > 60)
                {
                    TotalFare = 500 / 100 * 30;
                    Console.Write("TotalFare = {0}\n", TotalFare);
                    Console.WriteLine("senior citizen");
                }
                else
                {
                    Console.WriteLine("TotalFare: 500 ");
                    Console.WriteLine("Ticket Booked");

                }
                Console.ReadLine();
            }
        }
    }
    class program
    {
        static void Main()
        {
            libraryproject lp = new libraryproject();
            lp.CalculateConcession();
        }
    }
}
