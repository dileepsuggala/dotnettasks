using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
             adolayer ai = new adolayer();
            int SId = int.Parse(TextBox.Text);
            string Sname = TextBox1.Text;
            string course = TextBox2.Text;
            string Startdate =TextBox3.Text;
            ai.insertrow(SId, Sname, course, Startdate);

                
        }
    }
}