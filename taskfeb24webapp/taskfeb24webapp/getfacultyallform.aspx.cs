using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskfeb24webapp
{
    public partial class getfacultyallform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                adolayerfaculty af = new adolayerfaculty();
                var faclist = af.getallrecords();
                GridView1.DataSource = faclist;
                GridView1.DataBind();
            }
        }
    }
}