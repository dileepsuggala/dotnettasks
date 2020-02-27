using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskfeb24webapp
{
    public partial class insertcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            adocourse ac = new adocourse();
            int cid = int.Parse(TextBox1.Text);
            string cname = TextBox2.Text;
            string startdate = TextBox3.Text;
            ac.insertcourse(cid,cname,startdate);
        }
    }
}