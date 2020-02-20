using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task6thfeb
{
    public partial class gettrainee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            traineedatalayer gtd = new traineedatalayer();
            int Id = Convert.ToInt32(TextBox.Text);
            var traineeget = gtd.selectbyid(Id);
            GridView1.DataSource = traineeget;
            GridView1.DataBind();
        }
    }
}