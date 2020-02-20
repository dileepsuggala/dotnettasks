using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Webgetstu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            adolayer asu = new adolayer();
            int Sid = Convert.ToInt32(TextBox.Text);
           var sinstu = asu.getstu(Sid);
            GridView1.DataSource = sinstu;
            GridView1.DataBind();
        }
    }
}