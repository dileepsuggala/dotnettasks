using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskfeb24webapp
{
    public partial class insertfacultyform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            adolayerfaculty af = new adolayerfaculty();
            int fid = int.Parse(TextBox1.Text);
            string fname = TextBox2.Text;
            af.insertfaculty(fid, fname);
        }
    }
}