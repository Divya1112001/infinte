using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prastice_Assign_07
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
            return EmployeeId + "       " + FirstName + "       " + LastName + "       " + Title + "       " + DOB + "       " + DOJ + "       " + city;
        }
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>()
               {
              new Employee { EmployeeId = 1001, FirstName = "Malcolm", LastName = "Daruwalla" , Title = "Manager",     DOB =Convert.ToDateTime("16 / 11 / 1984"),  DOJ =Convert.ToDateTime("08 / 06 / 2011"),  city = "Mumbai" },
              new Employee { EmployeeId = 1002, FirstName = "Asdin",   LastName = "Dhalla" ,    Title = "AsstManager", DOB =Convert.ToDateTime("20 / 08 / 1984"),  DOJ =Convert.ToDateTime("07 / 07 / 2012"),  city = "Mumbai" },
              new Employee { EmployeeId = 1003, FirstName = "Madhavi", LastName = "Oza",        Title = "Cosultant",   DOB =Convert.ToDateTime("14 / 11 / 1987"),  DOJ =Convert.ToDateTime("12 / 04 / 2015"), city = "pune" },
              new Employee { EmployeeId = 1004, FirstName = "Saba",    LastName = "Shaikh",     Title = "SE",          DOB =Convert.ToDateTime("03 / 06 / 1990"),  DOJ =Convert.ToDateTime("02 / 02 / 2016"),  city = "pune" },
              new Employee { EmployeeId = 1005, FirstName = "Nazia",   LastName = "Shaikh",     Title = "SE",          DOB =Convert.ToDateTime("08 / 03 / 1991"),  DOJ =Convert.ToDateTime("02 / 02 / 2016"),  city = "Mumbai" },
              new Employee { EmployeeId = 1006, FirstName = "Amit",    LastName = "Pathak",     Title = "Consultant",  DOB =Convert.ToDateTime("07 / 11 / 1989"),  DOJ =Convert.ToDateTime("08 / 08 / 2014"),  city = "Chennai" },
              new Employee { EmployeeId = 1007, FirstName = "Vijay",   LastName = "Natrajan",   Title = "Consultant",  DOB =Convert.ToDateTime("02 / 12 / 1989"),  DOJ =Convert.ToDateTime("01 / 06 / 2015"),  city = "Mumbai" },
              new Employee { EmployeeId = 1008, FirstName = "Rahul",   LastName = "Dubey",      Title = "Associate",   DOB =Convert.ToDateTime("11 / 11 / 1993"),  DOJ =Convert.ToDateTime("06 / 11 / 2014"), city = "Chennai" },
              new Employee { EmployeeId = 1009, FirstName = "Suresh",  LastName = "Mistry",     Title = "Manager",     DOB =Convert.ToDateTime("12 / 08 / 1992"),  DOJ =Convert.ToDateTime("03 / 12 / 2014"), city = "Chennai" },
              new Employee { EmployeeId = 1010, FirstName = "Sumit",   LastName = "Shah",       Title = "Manager",     DOB =Convert.ToDateTime("12 / 04 / 1991"),  DOJ =Convert.ToDateTime("02 / 01 / 2016"),  city = "pune" },
               };


            //Display detail of all the employee                                    -------- a -1
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Display detail of all the employee");
            var result = from s in emplist where s.EmployeeId >= 1001 select s;
            Console.WriteLine("EmployeeId\t FirstName \tLastName \tTitle \tDOB\t DOJ\t city");
            Console.WriteLine("      ");
            foreach (Employee e in result)
            {
                Console.WriteLine(e);
            }


            //Display details of all the employee whose location is not Mumbai       --------b - 2
             Console.WriteLine("-----------------------------");
             Console.WriteLine("Display details of all the employee whose location is not Mumbai");
             var result1 = from s1 in emplist where s1.city != "Mumbai" select s1;
             Console.WriteLine("EmployeeId\t FirstName \tLastName \tTitle \tDOB\t DOJ\t city");
             Console.WriteLine("     ");
             foreach (Employee e1 in result1)
             {
                 Console.WriteLine(e1);
             }


            //Display details of all the employee whose title is AsstManager          -------- c - 3
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" Display details of all the employee whose title is AsstManager");
            var result2 = from s2 in emplist where s2.Title == "AsstManager" select s2;
            Console.WriteLine("EmployeeId\t FirstName \tLastName \tTitle \tDOB\t DOJ\t city");
            Console.WriteLine("        ");
            foreach (Employee e2 in result2)
            {
                Console.WriteLine(e2);
            }


            //Display details of all the employee whose Last Name start with S          ------- d - 4 
             Console.WriteLine("-----------------------------");
             Console.WriteLine(" Display details of all the employee whose Last Name start with S");
             var result3 = from s3 in emplist where (s3.LastName.StartsWith('S' + "") || s3.LastName.StartsWith('S' + ""))select s3;
             Console.WriteLine("EmployeeId\t FirstName \tLastName \tTitle \tDOB\t DOJ\t city");
             Console.WriteLine("        ");
             foreach (Employee e3 in result3)
             {
                 Console.WriteLine(e3);
             }


            //Display a list of all the employee who have joined before 1/1/2015               ------- e - 5
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Display a list of all the employee who have joined before 1/1/2015");
            var result4 = from e in emplist where e.DOJ > DateTime.Parse("1/1/2015") select e.FirstName; 
            Console.WriteLine("        ");
            foreach (var e4 in result4)
            {
                Console.WriteLine(e4);
            }


            //Display a list of all the employee whose date of birth is after 1/1/1990    ------ f - 6
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Display a list of all the employee whose date of birth is after 1/1/1990");
            var result5 = (from s5 in emplist  where s5.DOB > DateTime.Parse("1/1/1990")  select s5.FirstName);
            Console.WriteLine("        ");
            foreach (var e5 in result5)
            {
                Console.WriteLine(e5);
            }


            //Display a list of all the employee whose designation is Consultant and Associate   ----- g - 7 
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Display a list of all the employee whose designation is Consultant and Associate");
            var  result6 = from s6 in emplist where s6.Title == "Consultant" || s6.Title == "Associate" select s6;
            Console.WriteLine("        ");
            foreach (Employee e6 in result6)
            {
                Console.WriteLine(" FirstName = {0}, Title = {1}", e6.FirstName, e6.Title);
            }


            //Display total number of employees                                                   ------ h - 8
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Display total number of employees");
            Console.WriteLine("        ");
            Console.WriteLine($"Total number of Employees: { emplist.Count() }");


            //Display total number of employees belonging to “Chennai”                           ------- i - 9
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Display total number of employees belonging to “Chennai”");
             var result8 = (from s8 in emplist where s8.city == "Chennai" select s8).Count();
             Console.WriteLine("            ");
             Console.WriteLine("Total employee belonging to Chennai: " + result8);


            //Display highest employee id from the list                                          --------- j - 10
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Display highest employee id from the list");
            var result9 = (from a in emplist select a.EmployeeId).Max();
            Console.WriteLine("            ");
            Console.WriteLine(result9);

            //Display total number of employee who have joined after 1/1/2015                    --------- k - 11  
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" Display total number of employee who have joined after 1/1/2015");
            var result11 = (from s11 in emplist where s11.DOJ > DateTime.Parse("1/1/2015") select s11.FirstName);
            Console.WriteLine("        ");
            foreach (var e11 in result11)
            {
                Console.WriteLine(e11);
            }


            //Display total number of employee whose designation is not “Associate”              --------- l - 12
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Display total number of employee whose designation is not Associate");
            var result12 = (from s12 in emplist where s12.Title != "Associate" select s12.EmployeeId).Count();
            Console.WriteLine("        ");
            Console.WriteLine("not associate :" + result12);


            //Display total number of employee based on City                                    ---------- m - 13
            Console.WriteLine("----------------------------");
            Console.WriteLine("Display total number of employee based on City");
            var result13 = (from s13 in emplist group s13.EmployeeId by s13.city into grp select new { city = grp.Key.ToString(), Count = grp.Count() }).ToList();
            Console.WriteLine("        ");
            foreach (var e13 in result13)
            {
                Console.WriteLine(e13);
            }


            //Display total number of employee based on city and title                          ---------- n - 14 
            Console.WriteLine("----------------------------");
            Console.WriteLine(" Display total number of employee based on City");
            var result14 = (from s14 in emplist group s14.EmployeeId by new { s14.city, s14.Title } into grp select new { city = grp.Key.city, Title = grp.Key.Title, Count = grp.Count() }).ToList();
            Console.WriteLine("        ");
            foreach (var e14 in result14)
            {
                Console.WriteLine(e14);
            }
             

            //Display total number of employee who is youngest in the list                      ---------- o - 15  
            Console.WriteLine("Display total number of employee who is youngest in the list");
            var result15 = (from s15 in emplist select s15.DOB + "" + "name:" + s15.FirstName + "" + "  is the youngest employee").Min();
            Console.WriteLine(result8);

            Console.Read();
            }
        }
    }
