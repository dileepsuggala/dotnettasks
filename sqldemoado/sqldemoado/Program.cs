using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sqldemoado
{
    class Program
    {
        static void Main(string[] args)
        {
            // sqlwithlocaldb();

            // sqlwithserverdb();
            string constr = @"Data Source=BLT1069\SQLEXPRESS2014;Initial Catalog=dileep;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {

                try
                { 

                  string querystr = "insert into department(Did,Dname) values ("+"'104'"+","+"'IT')";
               // string querystr = "select * from department";
                
               
                    //string querystr = "select * from product";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                     cmd.ExecuteNonQuery();
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        




    }

    private static void sqlwithserverdb()
        {
            string constr = @"Data Source=BLT1069\SQLEXPRESS2014;Initial Catalog=dileep;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {

                    string querystr = "select * from course";


                    //string querystr = "select * from product";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }

        private static void sqlwithlocaldb()
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dileep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try { 
                
                    string querystr = "select * from stu";
                

                    //string querystr = "select * from product";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
