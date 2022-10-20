//Write a program to find the Sum and the Average points scored by the teams in the IPL.
//Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) that takes no.of matches as input and accepts that many scores from the user. 
//The function should then display the Average and Sum of the scores. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Test
    {
        static void Main(string[] args)
        {
            Box T = new Box();
            T.add2Box();
        }
    }
    class Box
    {
        int L, B, L1, B1;
        public void Box_0ne()
        {
            Console.WriteLine("Enter the Length_1");
            L = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Breath_1");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("L" + L + "," + "B" + B);
        }
        public void Box_two()
        {
            Console.WriteLine("Enter the Length_2");
            L1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Breath_2");
            B1 = int.Parse(Console.ReadLine());
            Console.WriteLine("L1" + L1 + "," + "B1" + B1);
        }

    }
    public void add2Box()
    {
        Box b = new Box();
        b.Box_0ne();
        b.Box_two();
        int sum;
    }
  }
