
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _04_11_2022
{
    [Table("tbl_Book")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
    }
    public  class BookContext : DbContext
    {
        public BookContext() : base("name=Bookcontext")
        { }

        //include all models as DbSet Objects
        public DbSet<Book> Books { get; set; }
        public DbSet<Publishers> Publisher { get; set; }
        public DbSet<Authors> Author { get; set; }


    }
    class Program
    {
        static BookContext bc = new BookContext();
        static void ShowBooks()
        {
            var book = from b in bc.Books
                       select b;

            foreach (var item in book)
            {
                Console.WriteLine(item.BookId + " " + item.BookName);
            }
        }

        static void UpdateBooks()
        {
            var bk = bc.Books.FirstOrDefault(b => b.BookId == 3);

            bk.BookName = "Intro to Dot Net Programming";
            bc.SaveChanges();
            //for delete
            //bc.Books.Remove(bk);
            //bc.SaveChanges();       

        }
        static void Callproc()
        {
            // var blist=bc.
        }
        static void Main(string[] args)
        {
            //UpdateBooks();
            //ShowBooks();
            Callproc();
            //using(var db= new BookContext())
            //{
            //    db.Books.Add(new Book { BookName = "Introduction to EF" });
            //    db.SaveChanges();

            //    foreach(var bk in db.Books)
            //    {
            //        Console.WriteLine(bk.BookId + " "+ bk.BookName);
            //    }
            //}
            Console.Read();
        }

        public class Publishers
        {
            [Key]
            public int PublisherId { get; set; }
            public string PublisherName { get; set; }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .MapToStoredProcedures(b => b.Insert(x => x.HasName("insertbook", "dbo"))
                                            .Update(x => x.HasName("updatebook", "dbo"))
                                            .Delete(x => x.HasName("deletebook", "dbo")));

        }

    }
}
