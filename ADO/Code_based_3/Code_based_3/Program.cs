
/*Using Ado.net classes/methods, insert employee record in the table by invoking the procedure  (insertemployee())
 
 Display all the records (including the newely added record) -(Display())*/

using System;
using System.Data;
using System.Data.SqlClient;

namespace Code_based_3
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=LAPTOP-PULFH92A;initial catalog=InfiniteDB;" +
            "Integrated Security=True;Trusted_Connection=True");
            con.Open();
            return con;
        }

        public static void InsertEmployee()
        {
            try
            {
                con = getConnection();
                {

                    Console.WriteLine("Please enter empname,emptype,empsal");
                    // int empno = Convert.ToInt32(Console.ReadLine());
                    string empname = Console.ReadLine();
                    int empsal = Convert.ToInt32(Console.ReadLine());
                    string emptype = Console.ReadLine();

                    cmd = new SqlCommand("exec InsertEmployeeDetails @empname,@empsal,@emptype", con);
                    cmd.Parameters.AddWithValue("@empname", empname);
                    cmd.Parameters.AddWithValue("@empsal", empsal);
                    cmd.Parameters.AddWithValue("@emptype", emptype);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            InsertEmployee();
            Console.ReadKey();
        }
    }
}





  