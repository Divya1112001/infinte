//Create an console application to book train tickets. Create a Passanger class with (Name, Age) and write a function called TicketBooking(int no_of_tickets) that takes no.of tickets to be booked. 
//If the no of tickets is > 2 per booking, raise an user defined exception, and print "cannot book more than 2 tickets". Else Print  "Ticket Booked Successfully". 
//Add a Test class to call TicketBooking method by accepting all required details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class passanger
    {
        public void ticketbooking()
        {
            string Name;
            Console.WriteLine("Enter a Name");
            Name = Convert.ToString(Console.ReadLine());
            int age;
            Console.WriteLine("Enter  age");
            age = Convert.ToInt16(Console.ReadLine());
            int no_of_tickets;
            Console.WriteLine("NoOfTickets booked : ");
            no_of_tickets = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < no_of_tickets; i++)
            {
                if (no_of_tickets > 2)
                {
                    Console.WriteLine("canot book more than 2 tickets");

                }
                else
                {
                    Console.WriteLine("ticket booked successfully");
                }
                Console.ReadLine();
            }
        }
    }
    class test
    {
       static void Main()
        {
            passanger p = new passanger();
            p.ticketbooking();
        }
    }

}
