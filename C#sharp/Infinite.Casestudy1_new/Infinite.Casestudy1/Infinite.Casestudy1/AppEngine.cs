using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infinite.Casestudy1;


namespace Infinite.Casestudy2
{

    class Enroll
    {
        public LocalDate enrollmentDate { get; set; }
        public int CId { get; set; }
        public string CName { get; set; }
        public string Duration { get; set; }
        public double Fees { get; set; }
        public int Stuid { get; set; }
        public string Sname { get; set; }
        public string DOB { get; set; }

        public Enroll(int cId, string cName, string duration, double fees, int stuid, string sname, string dOB)
        {
            CId = cId;
            CName = cName;
            Duration = duration;
            Fees = fees;
            Stuid = stuid;
            Sname = sname;
            DOB = dOB;
        }





    }
    class AppEngine
    {
        Student[] s = new Student[3];
        Course[] c = new Course[3];
        Enroll[] E = new Enroll[3];

        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=MEDL011027400\\SQLEXPRESS;initial catalog=studentmanagement;" + "Integrated Security=True");
            con.Open();
            return con;
        }



        public void introduce()
        {


            Console.WriteLine(" adding new courses to list");
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
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + "" + dr[3]);
                    }
                    Console.WriteLine("Insertion Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public void register()
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
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2].ToString());
                    }
                    Console.WriteLine("Insertion Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Selectstudents()
        {
            con = getConnection();
            try
            {

                cmd = new SqlCommand("select * from student");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);

                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error in the Server...");
            }
            finally
            {
                con.Close();
            }
        }
        public void updatestudents()
        {

            con = getConnection();
            try
            {
                Console.WriteLine("Enter the student code to update:");
                int ecode = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("Select * from student where stdid=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", ecode);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }

                con.Close();

                Console.WriteLine("Are you Sure to update this student? Y/N :");
                string status = Console.ReadLine();

                if (status == "y" || status == "Y")
                {
                    Console.WriteLine("enter the student name");
                    string stdname = Console.ReadLine();
                    Console.WriteLine("enter the date of birth ");
                    DateTime dob = Convert.ToDateTime(Console.ReadLine());
                    cmd = new SqlCommand("UPDATE student SET stdname=@stdname,dob=@dob where stdid=@eid ", con);
                    cmd.Parameters.AddWithValue("@stdname", stdname);
                    cmd.Parameters.AddWithValue("@dob", dob.ToShortDateString()); ;
                    cmd.Parameters.AddWithValue("@eid", ecode);
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record update Successfully...");
                    }
                    else
                        Console.WriteLine("Contact DBA..");
                }
                else
                {
                    Console.WriteLine("You Opted not to update the student");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void deletestudents()
        {

            con = getConnection();
            try
            {
                Console.WriteLine("Enter the student code to delete:");
                int ecode = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("Select * from student where stdid=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", ecode);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }

                con.Close();

                Console.WriteLine("Are you Sure to delete this student? Y/N :");
                string status = Console.ReadLine();

                if (status == "y" || status == "Y")
                {


                    cmd = new SqlCommand("delete from student where stdid=@eid ", con);
                    cmd.Parameters.AddWithValue("@eid", ecode);
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record deleted Successfully...");
                    }
                    else
                        Console.WriteLine("Contact DBA..");
                }
                else
                {
                    Console.WriteLine("You Opted not to delete the student");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void updatecourses()
        {

            con = getConnection();
            try
            {
                Console.WriteLine("Enter the course code to update:");
                int ecode = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("Select * from Course where Cid=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", ecode);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }

                con.Close();

                Console.WriteLine("Are you Sure to update this Course? Y/N :");
                string status = Console.ReadLine();

                if (status == "y" || status == "Y")
                {
                    Console.WriteLine("enter the course name ");
                    string courname = Console.ReadLine();
                    Console.WriteLine("enter the course duration ");
                    string Cdura = Console.ReadLine();
                    Console.WriteLine("enter the course fee ");
                    float cfees = float.Parse(Console.ReadLine());
                    cmd = new SqlCommand("UPDATE Course SET cname=@courname,cdur=@Cdura ,Cfee=@Cfees where Cid=@eid ", con);
                    cmd.Parameters.AddWithValue("@courname", courname);
                    cmd.Parameters.AddWithValue("@Cdura", Cdura);
                    cmd.Parameters.AddWithValue("@cfees", @cfees);
                    cmd.Parameters.AddWithValue("@eid", ecode);
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record update Successfully...");
                    }
                    else
                        Console.WriteLine("Contact DBA..");
                }
                else
                {
                    Console.WriteLine("You Opted not to update the student");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void deletecourse()
        {
            con = getConnection();
            try
            {
                Console.WriteLine("Enter the course code to delete:");
                int ecode = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("Select * from Course where Cid=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", ecode);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }

                con.Close();

                Console.WriteLine("Are you Sure to delete this course? Y/N :");
                string status = Console.ReadLine();

                if (status == "y" || status == "Y")
                {


                    cmd = new SqlCommand("delete from Course where Cid=@eid ", con);
                    cmd.Parameters.AddWithValue("@eid", ecode);
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record deleted Successfully...");
                    }
                    else
                        Console.WriteLine("Contact DBA..");
                }
                else
                {
                    Console.WriteLine("You Opted not to delete the student");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public void SelectCourses()
        {
            con = getConnection();
            try
            {

                cmd = new SqlCommand("select * from Course");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3]);

                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error in the Server...");
            }
            finally
            {
                con.Close();
            }
        }
        public void Selectenrollment()
        {
            con = getConnection();
            try
            {

                cmd = new SqlCommand("select * from Enrollment");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + "" + dr[3] + " " + dr[4] + " " + dr[5] + "" + dr[6]);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error in the Server...");
            }
            finally
            {
                con.Close();
            }
        }
        public void updateenrollment()
        {
            con = getConnection();
            try
            {
                Console.WriteLine("Enter the enrollment  code to update:");
                int ecode = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("Select * from Enrollment where cid=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", ecode);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }

                con.Close();

                Console.WriteLine("Are you Sure to update this Enrollment data? Y/N :");
                string status = Console.ReadLine();

                if (status == "y" || status == "Y")
                {
                    Console.WriteLine("enter the course id ");
                    string cid = Console.ReadLine();
                    Console.WriteLine("enter the student id  ");
                    string stdid = Console.ReadLine();
                    Console.WriteLine("enter the student name  ");
                    string stdname = Console.ReadLine();
                    Console.WriteLine("enter the course name  ");
                    string cname = Console.ReadLine();
                    Console.WriteLine("enter the course duration ");
                    string cdur = Console.ReadLine();
                    Console.WriteLine("enter the course fees  ");
                    float fees = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter the enrollment date");
                    DateTime enrolldate = Convert.ToDateTime(Console.ReadLine());
                    cmd = new SqlCommand("UPDATE Enrollment SET cid=@cid,sid=@stdid,Sname=@stdname,Cname=@cname,duration=@cdur,fees=@fees,Enrollmentdate=@enrolldate where cid=@eid ", con);
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@stdid", stdid);
                    cmd.Parameters.AddWithValue("@stdname", stdname);
                    cmd.Parameters.AddWithValue("@cname", cname);
                    cmd.Parameters.AddWithValue("@cdur", cdur);
                    cmd.Parameters.AddWithValue("@fees", fees);
                    cmd.Parameters.AddWithValue("@enrolldate", enrolldate);
                    cmd.Parameters.AddWithValue("@eid", ecode);
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record update Successfully...");
                    }
                    else
                        Console.WriteLine("Contact DBA..");
                }
                else
                {
                    Console.WriteLine("You Opted not to update the student");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void deleteenrollment()
        {
            con = getConnection();
            try
            {
                Console.WriteLine("Enter the enrollment code to delete:");
                int ecode = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("Select * from Enrollment where Cid=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", ecode);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }

                con.Close();

                Console.WriteLine("Are you Sure to delete this enrollment data? Y/N :");
                string status = Console.ReadLine();

                if (status == "y" || status == "Y")
                {


                    cmd = new SqlCommand("delete from Enrollment where Cid=@eid ", con);
                    cmd.Parameters.AddWithValue("@eid", ecode);
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record deleted Successfully...");
                    }
                    else
                        Console.WriteLine("Contact DBA..");
                }
                else
                {
                    Console.WriteLine("You Opted not to delete the student");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }





        public Student[] ListOfStudents()
        {
            Console.WriteLine("the list of students");

            Student[] se = new Student[3];
            se[0] = new Student(1, "ramya", "12/08/1998");
            se[1] = new Student(2, "neelima", "4/07/2000");
            se[2] = new Student(3, "anuhya", "4/06/20002");
            for (int i = 0; i < se.Length; i++)
            {

                Console.WriteLine(se[i].Stuid + se[i].Sname + se[i].DOB);
            }
            return se;

        }
        public Course[] listOfCourses()
        {
            Console.WriteLine("the list of courses");

            Course[] ce = new Course[3];
            ce[0] = new Course(1, "java", "2 months", 10000);
            ce[1] = new Course(2, "c++", "2 months", 10000);
            ce[2] = new Course(3, "Dotnet", "2 months", 10000);
            for (int i = 0; i < ce.Length; i++)
            {

                Console.WriteLine(ce[i].CId + ce[i].CName + ce[i].Duration + ce[i].Fees);
            }
            return ce;
        }
        public void enroll()
        {

            try
            {
                con = getConnection();
                {
                    Console.WriteLine("enter the course id");
                    int courid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the student id");
                    int studNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter name of the student");
                    string studName = Console.ReadLine();
                    Console.WriteLine("enter the course name ");
                    string studcourse = Console.ReadLine();
                    Console.WriteLine("enter course duration");
                    string courseduration = Console.ReadLine();
                    Console.WriteLine("enter the course fees");
                    float fees = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter the enrollment date");
                    DateTime enrollment = Convert.ToDateTime(Console.ReadLine());

                    cmd = new SqlCommand("insert into Enrollment(cid, sid, Sname,Cname,duration, fees,EnrollmentDate) values(@cid, @sid, @Sname,@Cname,@duration,@fees,@EnrollmentDate)", con);
                    cmd.Parameters.AddWithValue("@cid", courid);
                    cmd.Parameters.AddWithValue("@sid", studNo);
                    cmd.Parameters.AddWithValue("@Sname", studName);
                    cmd.Parameters.AddWithValue("@Cname", studcourse);
                    cmd.Parameters.AddWithValue("@duration", courseduration);
                    cmd.Parameters.AddWithValue("@fees", fees);
                    cmd.Parameters.AddWithValue("@EnrollmentDate", enrollment.ToShortDateString());
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + "" + dr[3] + " " + dr[4] + " " + dr[5] + "" + dr[6]);
                    }
                    Console.WriteLine("Insertion Successfully");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public Enroll[] listOfEnrollments()
        {

            Enroll[] EE = new Enroll[3];
            for (int i = 0; i < E.Length; i++)
            {
                EE[i] = new Enroll(E[i].CId, E[i].CName, E[i].Duration, E[i].Fees, E[i].Stuid, E[i].Sname, E[i].DOB)
                {
                    CId = E[i].CId,
                    CName = E[i].CName,
                    Duration = E[i].Duration,
                    Fees = E[i].Fees,
                    Stuid = E[i].Stuid,
                    Sname = E[i].Sname,
                    DOB = E[i].DOB,
                };
            }
            return EE;
        }
    }

}

