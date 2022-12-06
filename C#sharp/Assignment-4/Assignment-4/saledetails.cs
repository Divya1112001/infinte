// Create a class called Saledetails which has data members like Salesno,  Productno,  Price, dateofsale, Qty, TotalAmount
//Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty* Price
//Pass the other information like SalesNo, Productno, Price, Qty and Dateof sale through constructor
//call the show data method to display the values.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class saledetails
    {
      
            //data member
            int SalesNo;
            int ProductionNo;
            int Prize;
            int DateOfSale;
            int Qty;
        public int TotalAmount;

        //Method
        public void sales()
        {
            int Qty, Prize;
            Console.WriteLine("Enter the Qty");
            Qty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Prize");
            Prize = int.Parse(Console.ReadLine());
            TotalAmount = Qty * Prize;

        }

        //constructor
        public saledetails(int SalesNo, int ProductionNo, int Qty, int DateOfSale, int Prize)
        {
            this.SalesNo = SalesNo;
            this.ProductionNo = ProductionNo;
            this.Prize = Prize;
            this.Qty = Qty;
            this.DateOfSale = DateOfSale;

        }
        public void Displaysalesdetails()
        {
            Console.WriteLine($"Qty : {Qty},salesNo : {SalesNo},ProductionNo : {ProductionNo},Prize : {Prize},DateOfSale : {DateOfSale},TotalAmount : {Qty * Prize}");
            Console.Read();
        }
        static void Main()
        {
            saledetails s = new saledetails(12, 123, 5, 5, 10);
            s.Displaysalesdetails();

        }

    }
}
