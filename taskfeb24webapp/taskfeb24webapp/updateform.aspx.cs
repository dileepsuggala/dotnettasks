using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskfeb24webapp
{
    public partial class updateform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            adolayer au = new adolayer();
            int sid = Convert.ToInt32(Textbox1.Text);
            string sname = Textbox2.Text;
            au.updatestudent(sid, sname);
        }
    }
}