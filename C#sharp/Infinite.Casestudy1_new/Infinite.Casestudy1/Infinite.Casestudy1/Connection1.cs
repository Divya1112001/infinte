using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.Casestudy4
{
    class Connection1
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=ICS-LAP-4022\\SQLEXPRESS;initial catalog=InDB;" + "Integrated Security=True");
            con.Open();
            return con;
        }

        public void std()
        {
            try
            {
                con = getConnection();
                {
                    Console.WriteLine("Enter student id,name, DOB :");
                    int stdid = Convert.ToInt32(Console.ReadLine());
                    string stdname = Console.ReadLine();
                    DateTime dob = Convert.ToDateTime(Console.ReadLine());

                    cmd = new SqlCommand("INSERT INTO student (stdid ,stdname,dob) VALUES (@stdid,@stdname,@dob)", con);
                    cmd.Parameters.AddWithValue("@stdid", stdid);
                    cmd.Parameters.AddWithValue("@stdname", stdname);
                    cmd.Parameters.AddWithValue("@dob", dob.ToShortDateString());
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
                    }
                    Console.WriteLine("Insertion Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

              //  con.close();
            }
        }
        public void cour()
        {
            try
            {
                con = getConnection();
                {
                    Console.WriteLine("Enter Course id,name, Duration,fee :");
                    int Courid = Convert.ToInt32(Console.ReadLine());
                    string CouName = Console.ReadLine();
                    String CouDur = Console.ReadLine();
                    float CouFee = float.Parse(Console.ReadLine());

                    cmd = new SqlCommand("insert into Course(Cid, cname, cdur, Cfee) values(@Cid, @cname, @cdur, @Cfee)", con);
                    cmd.Parameters.AddWithValue("@Cid", Courid);
                    cmd.Parameters.AddWithValue("@cname", CouName);
                    cmd.Parameters.AddWithValue("@cdur", CouDur);
                    cmd.Parameters.AddWithValue("@Cfee", CouFee);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]+" " + dr[3]);
                    }
                    Console.WriteLine("Insertion Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
              //  con.close();
            }
        }
    }
}

