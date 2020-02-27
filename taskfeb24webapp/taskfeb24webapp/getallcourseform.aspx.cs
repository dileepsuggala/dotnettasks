using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskfeb24webapp
{
    public partial class getallcourseform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                adocourse ac = new adocourse();
                var courselist = ac.getallcourserecords();
                GridView1.DataSource = courselist;
                GridView1.DataBind();
            }
        }
    }
}