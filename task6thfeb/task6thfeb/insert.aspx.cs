using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task6thfeb
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            { 
            traineedatalayer tdi = new traineedatalayer();
            int Id = Int32.Parse(TextBox.Text);
            string Tname = TextBox1.Text;
            string Location = TextBox2.Text;
            string Techdomain = TextBox3.Text;
            string Startdate = TextBox4.Text;
            tdi.insert(Id,Tname,Location,Techdomain,Startdate);

           
                Label6.Text = "data validated";
            }
        }
    }
}