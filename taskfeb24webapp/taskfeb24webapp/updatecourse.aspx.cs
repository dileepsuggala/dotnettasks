using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskfeb24webapp
{
    public partial class updatecourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            adocourse acu = new adocourse();
            int cid = Convert.ToInt32(Textbox1.Text);
           
            string startdate = Textbox2.Text;
            acu.updatecourse(cid,startdate);
        }
    }
}