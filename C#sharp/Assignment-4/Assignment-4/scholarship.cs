//Create a class called Scholarship which has int Totalmarks and float fees as fields and a function Public float Merit(int m, float f) that takes Totalmarks and fees as an input.
//If the given marks is >= 70 and <=80, then calculate scholarship amount as 20% of the fees
//If the given mark is > 80 and <=90, then calculate scholarship amount as 30% of the fees
//If the given mark is >90, then calculate scholarship amount as 50% of the fees.
//In all the cases return the Scholarship amount

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class scholarship
    {
        float discount;

        public float Merit()
        {
            int m;
            float f;
            Console.WriteLine("Enter the m");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the f");
            f = int.Parse(Console.ReadLine());

            if (m > 70 && m <= 80)
            {
                discount = (m * 20) / f;
                f = m - discount;
                Console.WriteLine(f);
                Console.ReadLine();

            }
            else

                if (m > 80 && m <= 90)
            {
                discount = (m * 30) / f;
                f = m - discount;
                Console.WriteLine(f);
                Console.ReadLine();
            }

            else

                if (m > 90)
            {
                discount = (m * 50) / f;
                f = m - discount;
                Console.WriteLine(f);
                Console.ReadLine();
            }
            return discount;

        }
        static void Main()
        {
            scholarship p = new scholarship();
            p.Merit();

        }
    }
}
