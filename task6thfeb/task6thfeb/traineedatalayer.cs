using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace task6thfeb
{
    public class traineedatalayer
    {
        string constr = "";
        public traineedatalayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet selectall()
        {
            DataSet ds = new DataSet();
            string selqry = "select * from Trainee";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selqry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);

                }
            }
            catch (Exception ex)
            {

            }
            return ds;
        }
       

        public void insert(int Id, string Tname, string Location,string Techdomain, string Startdate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Tname", Tname);
                    cmd.Parameters.AddWithValue("@Location",Location);
                    cmd.Parameters.AddWithValue("@Techdomain", Techdomain);
                    cmd.Parameters.AddWithValue("@Startdate", Startdate);
                    cmd.CommandText = "inserttrainee";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
        public DataSet selectbyid(int Id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.CommandText = "gettrainee";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch { }
            return ds;
        }

        public void update(int Id, string Techdomain)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Techdomain",Techdomain);
                    cmd.CommandText = "updatetrainee";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter uda = new SqlDataAdapter(cmd);
                    uda.Fill(ds);
                    uda.Update(ds);
                }
            }
            catch { }
        }
    }
}

    
