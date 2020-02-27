using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace taskfeb24webapp
{
    public class adocourse
    {

        string constr = "";
        public adocourse()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet getallcourserecords()
        {
            DataSet ds = new DataSet();
            string selqry = "select * from course";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selqry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }
            }
            catch (Exception ex) { }
            return ds;
        }
        public void insertcourse(int cid, string cname, string startdate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@cname", cname);
                    cmd.Parameters.AddWithValue("@startdate", startdate);

                    cmd.CommandText = "insertcourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);
                }
            }
            catch { }
        }
        public void updatecourse(int cid, string startdate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cid", cid);

                    cmd.Parameters.AddWithValue("@startdate", startdate);

                    cmd.CommandText = "updatecourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);
                }
            }
            catch { }
        }
        public DataSet getcoursebyid(int cid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.CommandText = "getcourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);

                }
            }
            catch (Exception ex)
            {

            }
            return ds;
        }
        public void deletecourse(int cid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.CommandText = "delcourse";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}