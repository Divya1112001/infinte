using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Dotnet
{
    delegate int NumberChanger(int n);
    delegate void Multidel();

    class Delegates2
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }

    class TestDelegate
    {
        static void Main()
        {
            //creating instances of the delegate and assigning methods
            NumberChanger nc1 = new NumberChanger(Delegates2.AddNum);
            NumberChanger nc2 = new NumberChanger(Delegates2.MultiplyNum);

            Console.WriteLine("The original values of num :{0}", Delegates2.getNum());
            //calling the methods using delegate objects
            nc1(25); //method pointed by the nc1 object is called (AddNum)
            Console.WriteLine("Value of Num after Add delegate call is :{0}", Delegates2.getNum());
            nc2(5);
            Console.WriteLine("The Value of Num after Multiply Delegate call is {0}",Delegates2.getNum());

            Console.Read();
        }
    }

}
