﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task6thfeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                traineedatalayer tdl = new traineedatalayer();
                var traineedata = tdl.selectall();
                GridView1.DataSource = traineedata;
                GridView1.DataBind();
            }
        }
    }
}