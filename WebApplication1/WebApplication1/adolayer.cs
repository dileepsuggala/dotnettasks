using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class adolayer
    {
        string constr = "";
        public adolayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet getstu(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId",id);
                    cmd.CommandText = "getstu";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch { }return ds;
        }
        public void updatedata(int SId,string Startdate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", SId);
                    cmd.Parameters.AddWithValue("@Startdate", Startdate);
                    cmd.CommandText = "updatestu";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter uda = new SqlDataAdapter(cmd);
                    uda.Fill(ds);
                    uda.Update(ds);
                }
            }
            catch { }
        }

        public void insertrow(int SId,string Sname,string course,string Startdate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", SId);
                    cmd.Parameters.AddWithValue("@Sname", Sname);
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@Startdate", Startdate);
                    cmd.CommandText = "insertstu";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();
            string selqry = "select * from stu";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selqry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    
                }
            }
            catch(Exception ex)
            {

            }
            return ds;
        }
    }
}