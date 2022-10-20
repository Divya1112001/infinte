//Create a structure 
//struct Books
// private string title;
//private string author;
//private string subject;
//private int book_id;
//Include 2 methods called GetValues() and ShowValues() to accept and display details.
//create a Class called TestStructures that invokes the above methods of the structure to accept and display the details of the book

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class TestStructures
    {
        public static void Main(string[] args)
        {
            Books books = new Books();
            books.ShowValues("Java", "Herbert", "CSharp", 200);
            books.GetValues();
            Console.Read();
        }
    }

    struct Books
    {
        private string Title;
        private string Author;
        private string Subject;
        private int Book_Id;

        public void GetValues()
        {
            Console.WriteLine("------Book Details-----");
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Book ID: " + Book_Id);

        }
        public void ShowValues(string title, string authour, string subject, int book_id)
        {
            Title = title;
            Author = authour;
            Subject = subject;
            Book_Id = book_id;
        }

    }
}
