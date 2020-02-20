using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication3
{
    public class formtodb
    {
        string constr = "";
        public formtodb()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public void inserttodb(string name,string DOB,string gender,string hobbies,string education)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@hobbies", hobbies);
                    cmd.Parameters.AddWithValue("@education", education);
                    cmd.CommandText = "formtodb";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                }
            }
            catch
            { }
        }
    }
}