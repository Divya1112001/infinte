// Create an Abstract class Student with  Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) which takes grade as an input
//and checks whether student passed the course or not.  
//Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method
//For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. 
 //For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    abstract class student
    {
        abstract public int grade();

        public void display()
        {
            int grade;
            Console.WriteLine("Enter a grade");
            grade = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < grade; i++)
            {
                if (grade > 30)
                {
                    Console.WriteLine("pass");

                }
                else
                {
                    Console.WriteLine("fail");
                }
                Console.ReadLine();
            }
        }
    }

    class undergraduate : student
    {
        public undergraduate()
        {
            string Name;
            int id;
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter id : ");
            id = Convert.ToInt16(Console.ReadLine());
        }
        public override int grade()
        {
            int number;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt16(Console.ReadLine());
            string value = (number > 70) ? "TRUE" : "FALSE";
            Console.WriteLine($"{number} is {value}");
            return number;
        }
    }
    class graduate : student
    {
        public graduate()
        {
            string Name;
            int id;
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter id : ");
            id = Convert.ToInt16(Console.ReadLine());

        }
        public override int grade()
        {
            int number;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt16(Console.ReadLine());
            string value = (number > 80) ? "TRUE" : "FALSE";
            Console.WriteLine($"{number} is {value}");
            return number;

        }
    }
    class AbstractEg
    {
        static void Main()
        {
            student s = new undergraduate();
            Console.WriteLine(s.grade());
            student s1 = new graduate();
            Console.WriteLine(s.grade());
            s.display();

        }
    }
}

