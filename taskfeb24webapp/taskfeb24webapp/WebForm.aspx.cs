using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskfeb24webapp
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                adolayer al = new adolayer();
                var stlist = al.getallrecords();
                GridView1.DataSource = stlist;
                GridView1.DataBind();
            }
        }
    }
}