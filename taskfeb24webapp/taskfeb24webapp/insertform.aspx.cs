using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskfeb24webapp
{
    public partial class insertform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            adolayer ai = new adolayer();
            int sid = int.Parse(TextBox1.Text);
            string sname = TextBox2.Text;
            ai.insertstudent(sid, sname);
        }
    }
}