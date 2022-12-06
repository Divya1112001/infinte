using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Employee
    {
        int EmployeeId;
        string FirstName;
        string LastName;
        string Title;
        DateTime DOB;
        DateTime DOJ;
        string city;

        public override string ToString()
        {
            return EmployeeId + "     " + FirstName + "    " + LastName + "     " + Title + "     " + DOB + "    " + DOJ + "    " + city;
        }
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee { EmployeeId = 1001, FirstName = "Malcolm", LastName = "Daruwalla" , Title = "Manager",  DOB=Convert.ToDateTime(" 16 / 11 / 1984"),  DOJ =Convert.ToDateTime(" 8 / 6 / 2011"),  city = "Mumbai" },
                new Employee { EmployeeId = 1002, FirstName = "Asdin", LastName = "Dhalla" , Title = "AsstManager",  DOB =Convert.ToDateTime("20/08/1984"), DOJ =Convert.ToDateTime ("7/7/2012"), city = "pune" },
                new Employee { EmployeeId = 1003, FirstName = "Madhavi ", LastName = " Oza" , Title = "Consultant",  DOB =Convert.ToDateTime("14/11/1987"), DOJ =Convert.ToDateTime ("12/4/2015"), city = "pune" },
                new Employee { EmployeeId = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = Convert.ToDateTime("3 / 6 / 1990"), DOJ =Convert.ToDateTime ("2 / 2 / 2016"), city = "pune" },
                new Employee { EmployeeId = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = Convert.ToDateTime("8 / 3 / 1991"), DOJ =Convert.ToDateTime(" 2 / 2 / 2016"), city = "Mumbai" },
                new Employee { EmployeeId = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB =Convert.ToDateTime ("7 / 11 / 1989"), DOJ =Convert.ToDateTime ("8 / 8 / 2014"), city = "Chennai" },
                new Employee { EmployeeId = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB =Convert.ToDateTime(" 2 / 12 / 1989"), DOJ =Convert.ToDateTime ("1 / 6 / 2015"), city = "Mumbai" },
                new Employee { EmployeeId = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB =Convert.ToDateTime(" 11 / 11 / 1993"), DOJ =Convert.ToDateTime ("6 / 11 / 2014"), city = "Chennai" },
                new Employee { EmployeeId = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = Convert.ToDateTime("12 / 8 / 1992"), DOJ = Convert.ToDateTime("3 / 12 / 2014"), city = "Chennai" },
                new Employee { EmployeeId = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB =Convert.ToDateTime ("12 / 4 / 1991"), DOJ =Convert.ToDateTime ("2 / 1 / 2016"), city = "pune" },
            };
            Console.WriteLine("****************A**************");
            Console.WriteLine("Display detail of all the employee");
            var result = emplist.OrderBy(b => b.EmployeeId).ToList();

            Console.WriteLine("EmployeeId\t FirstName \t LastName\t Title\t DOB\t DOJ\tcity");
            Console.WriteLine("...............................");
            foreach (Employee e in result)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("****************B*******************");

            Console.WriteLine("Display details of all the employee whose location is not Mumbai");
            var result1 = from s in emplist where s.city != "Mumbai" select s;
            Console.WriteLine("EmployeeId\t FirstName \tLastName \tTitle \tDOB\t DOJ\t city");
            Console.WriteLine("............................");
            foreach (Employee e in result1)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("*****************C****************");
            Console.WriteLine(" Display details of all the employee whose title is AsstManager");

            var result2 = from s2 in emplist where s2.Title == "AsstManager" select s2;

            Console.WriteLine("EmployeeId\t FirstName \tLastName \tTitle \tDOB\t DOJ\t city");

            foreach (Employee e1 in result2)
            {
                Console.WriteLine(e1);
            }
            Console.WriteLine("**************D********************");
            Console.WriteLine(" Display details of all the employee whose Last Name start with S");

            var result3 = from s3 in emplist where s3.LastName[0] == 'S' select s3;

            Console.WriteLine("EmployeeId\t FirstName \tLastName \tTitle \tDOB\t DOJ\t city");
            Console.WriteLine("..................");
            foreach (Employee e2 in result3)
            {
                Console.WriteLine(e2);

            }

            Console.WriteLine("*************E******************");
            Console.WriteLine("Display a list of all the employee who have joined before 1/1/2015");
            var val13 = (from a in emplist
                         where a.DOJ < DateTime.Parse("1/1/2015")
                         select a.FirstName);
            foreach (var w in val13)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine("**************F***************");
            Console.WriteLine("Display a list of all the employee whose date of birth is after 1/1/1990");
            var val12 = (from a in emplist
                         where a.DOB > DateTime.Parse("1/1/1990")
                         select a.FirstName);
            foreach (var v in val12)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("**************G*****************");
            Console.WriteLine("Display a list of all the employee whose designation is Consultant and Associate");
            var val4 = from a in emplist where a.Title == "Consultant" || a.Title == "Associate" select a;
            foreach (var e5 in val4)
            {
                Console.WriteLine(" FirstName = {0}, Title = {1}", e5.FirstName, e5.Title);
            }
            Console.WriteLine("*****************H**********************");
            Console.WriteLine("Display total number of employees");
            Console.WriteLine($"Total number of Employees: { emplist.Count() }");



            Console.WriteLine("*****************I*************");
            Console.WriteLine("Display total number of employees belonging to “Chennai”");

            var result4 = (from s4 in emplist where s4.city == "Chennai" select s4).Count();
            Console.WriteLine("Total employee belonging to Chennai: " + result4);

            Console.WriteLine("*******************J*****************");
            Console.WriteLine("Display highest employee id from the list");
            var result10 = (from a in emplist select a.EmployeeId).Max();
            Console.WriteLine(result10);


            Console.WriteLine("***********K****************");
            Console.WriteLine(" Display total number of employee who have joined after 1/1/2015");
            var val14 = (from a in emplist
                         where a.DOJ > DateTime.Parse("1/1/2015")
                         select a.FirstName);
            foreach (var n in val14)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("**********L*******************");
            Console.WriteLine("Display total number of employee whose designation is not Associate");
            var result6 = (from s6 in emplist where s6.Title != "Associate" select s6.EmployeeId).Count();
            Console.WriteLine("not associate :" + result6);




            Console.WriteLine("*************M*************");
            var result7 = (from s7 in emplist
                           group s7.EmployeeId by s7.city into grp
                           select new
                           {
                               city = grp.Key.ToString(),
                               Count = grp.Count()

                           }).ToList();
            foreach (var r in result7)
            {
                Console.WriteLine(r);
            }


            Console.WriteLine("*******************n*******************");
            Console.WriteLine(" Display total number of employee based on City");

            var result9 = (from a in emplist
                           group a.EmployeeId by new { a.city, a.Title } into grp
                           select new
                           {
                               city = grp.Key.city,
                               Titel = grp.Key.Title,
                               Count = grp.Count()
                           }).ToList();
            foreach (var e in result9)
            {
                Console.WriteLine(e);
            }




            Console.WriteLine("*******************o***********************");
            Console.WriteLine("Display total number of employee who is youngest in the list");
            var result8 = (from a in emplist
                           select a.DOB + "" + "name:" + a.FirstName + "" + "  is the youngest employee").Min();
            Console.WriteLine(result8);
            Console.Read();
        }
    }

}
