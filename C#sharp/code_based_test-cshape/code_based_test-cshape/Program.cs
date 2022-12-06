
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace code_based_test_cshape
{
    public delegate int MyDelegate(int first );
    class Calculator
    {
        
        static int first = 10;

        public static int AddNum(int a )
        {
            first += a;
            return first;
        }
        public static int SubtractNum(int b)
        {
            first *= b;
            return first;
        }
        public static int MultiplyNum(int c)
        {
            first *= c;
            return first;
        }
        public static int DivisionNum(int d)
        {
            first *= d;
            return first;
        }
        public static int getNum()
        {
            return first;
        }
    }

    class Program
    {
        static void Main()
        {
          
            MyDelegate nc1 = new MyDelegate(Calculator.AddNum);
            MyDelegate nc2 = new MyDelegate(Calculator.SubtractNum);
            MyDelegate nc3 = new MyDelegate(Calculator.MultiplyNum);
            MyDelegate nc4 = new MyDelegate(Calculator.DivisionNum);


            Console.WriteLine("The original values of num :{0}", Calculator.getNum());
            Console.WriteLine("The Value of Num after Add Delegate call is {0}", nc1(5));
            Console.WriteLine("The Value of Num after Subtract Delegate call is {0}", nc2(5));
            Console.WriteLine("The Value of Num after Multiply Delegate call is {0}", nc3(5));
            Console.WriteLine("The Value of Num after Division Delegate call is {0}", nc4(5));
            Console.ReadKey();
        }
     }
}
