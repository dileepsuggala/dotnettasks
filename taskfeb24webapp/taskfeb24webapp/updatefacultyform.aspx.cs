using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskfeb24webapp
{
    public partial class updatefacultyform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            adolayerfaculty afu = new adolayerfaculty();
            int fid = Convert.ToInt32(Textbox1.Text);
            string fname = Textbox2.Text;
            afu.updatefaculty(fid, fname);
        }
    }
}