using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormupdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            adolayer au = new adolayer();
            int Sid = Convert.ToInt32(TextBox.Text);
            string Startdate = TextBox1.Text;
            au.updatedata(Sid, Startdate);
        }
    }
}