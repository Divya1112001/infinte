using System;
using System.Data;
using System.Data.SqlClient;

namespace _28_10
{
    class ConnectedArch
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        //function that establishes connection with the database server and returns
        // an object of SqlConnection type
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=LAPTOP-TJJ7D977;initial catalog=InfiniteDB;" +
                "Integrated Security=True");
            con.Open();
            return con;
        }
        public static void SelectEmployees()
        {
            con = getConnection();
            try
            {
                //cmd = new SqlCommand("select * from employee", con); 
                //or as below
                cmd = new SqlCommand("select * from employee");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3] + " " + dr[4] + " " + dr[5]);
                    //Console.WriteLine("Employee Id :" + dr[0]);
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

        public static void InsertEmployee()
        {
            con = getConnection();
            //giving static hard coded values as below will result in errors on successive execution
            // cmd = new SqlCommand("insert into employee values(300,'ADO',16000,'Others',5,'999999')",con);

            Console.WriteLine("Please enter Empno,Name,job,mgrid,hiredate,salary,comm,Deptno");
            int empno = Convert.ToInt32(Console.ReadLine());
            string ename = Console.ReadLine();
            string job = Console.ReadLine();
            int mgrid = Convert.ToInt32(Console.ReadLine());
            DateTime hiredate = DateTime.Parse(Console.ReadLine()); ;
            float sal = float.Parse(Console.ReadLine());
            int comm = Convert.ToInt32(Console.ReadLine());
            int deptno = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("insert into employee values(@empid,@empname,@empsal,@empgen,@empdid,@empph)", con);
            //command object has property known as parameters - a collection object
            //to the parameters collection, we have to add the parameters for insert
            cmd.Parameters.AddWithValue("@empno", empno);
            cmd.Parameters.AddWithValue("@empname", ename);
            cmd.Parameters.AddWithValue("@empjob", job);
            cmd.Parameters.AddWithValue("@empmgrid", mgrid);
            cmd.Parameters.AddWithValue("@emphiredate", hiredate);
            cmd.Parameters.AddWithValue("@empsal", sal);
            cmd.Parameters.AddWithValue("@empcomm", comm);
            cmd.Parameters.AddWithValue("@empdeptno", deptno);

            int records = cmd.ExecuteNonQuery();
            if (records > 0)
            {
                Console.WriteLine("Inserted successfully..");
            }
            else
                Console.WriteLine("Something went wrong..");
        }
        //execute scalar eg
        public static void ScalarEg()
        {
            con = getConnection();
            // cmd = new SqlCommand("select deptid from Employee where empid=4");
            cmd = new SqlCommand("Select count(empid) from employee");
            cmd.Connection = con;
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("There are {0}, no.of employees", count);
        }

        public static void DeleteEmployee()
        {
            con = getConnection();
            Console.WriteLine("Enter the employee code to delete:");
            int ecode = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Employee where Empid=@eid", con);
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
            Console.WriteLine("Are you Sure to delete this Employee? Y/N :");
            string status = Console.ReadLine();
            if (status == "y" || status == "Y")
            {
                cmd = new SqlCommand("delete from Employee where empid=@eid", con);
                cmd.Parameters.AddWithValue("@eid", ecode);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Record Deleted Successfully...");
                }
                else
                    Console.WriteLine("Contact DBA..");
            }
            else
            {
                Console.WriteLine("You Opted not to delete the Employee");
            }
        }

        public static void UpdateEmployee()
        {
            con = getConnection();
            Console.WriteLine("Enter the employee code to delete:");
            int ecode = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Employee where Empid=@eid", con);
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
            Console.WriteLine("Are you Sure to update this Employee? Y/N :");
            string status = Console.ReadLine();
            if (status == "y" || status == "Y")
            {
                cmd = new SqlCommand("update from Employee where empid=@eid", con);
                cmd.Parameters.AddWithValue("@eid", ecode);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("RecordUpdated Successfully...");
                }
                else
                    Console.WriteLine("Contact DBA..");
            }
            else
            {
                Console.WriteLine("You Opted not to te the Employee");
            }
        }
        public static void StoredProcCall()
        {
            con = getConnection();
            cmd = new SqlCommand("fewEmployee", con); //name of the procedure
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Employee Id: " + dr[0]);
                Console.WriteLine("Name :" + dr[1]);
                Console.WriteLine("Salary :" + dr[2]);
                Console.WriteLine("Gender :" + dr[3]);
                Console.WriteLine("Dept id :" + dr[4]);
                Console.WriteLine("Phone :" + dr[5]);
            }
        }
        public static void StoredProc_withParameter()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee Id :");
            int eid = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("getemployeebyid @empid", con);
            // cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", eid);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Employee Id: " + dr[0]);
                Console.WriteLine("Name :" + dr[1]);
                Console.WriteLine("Salary :" + dr[2]);
                Console.WriteLine("Gender :" + dr[3]);
                Console.WriteLine("Dept id :" + dr[4]);
                Console.WriteLine("Phone :" + dr[5]);
            }

        }

        static void Main(string[] args)
        {
            //ScalarEg();
            // DeleteEmployee();
            UpdateEmployee();
            //InsertEmployee();
            // SelectEmployees();
            Console.Read();
        }
    }
}
