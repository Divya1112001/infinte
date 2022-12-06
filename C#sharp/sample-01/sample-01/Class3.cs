using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Dotnet
{
    delegate int WithReturn(int x);
    class MulticastingDelegates_WithReturnValue
    {
        static int data;
        public int Square(int x)
        {
            data = x * x;
            return data;
        }

        public int Triplet(int x)
        {
            data = x * x * x;
            return data;
        }

        static void Main()
        {
            //creating class object
            MulticastingDelegates_WithReturnValue mrv = new MulticastingDelegates_WithReturnValue();
            //creating objects of the delegate
            WithReturn wr1 = new WithReturn(mrv.Square);
            WithReturn wr2 = new WithReturn(mrv.Triplet);
            Console.WriteLine(wr1(5));
            Console.WriteLine(wr2(5));
            //WithReturn wr;
            //wr = wr1 + wr2; //multicasting
            //the other way is
            WithReturn wr = new WithReturn(mrv.Square);
             wr += mrv.Triplet;
            int result = wr(2);
            Console.WriteLine(result); // the last methods return value only is stored
            Console.Read();
        }
    }
}