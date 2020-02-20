using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task6thfeb
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            traineedatalayer tdu = new traineedatalayer();
            int Id = Convert.ToInt32(TextBox.Text);
            string Techdomain = TextBox1.Text;
            tdu.update(Id,Techdomain);
        }
    }
}