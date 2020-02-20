using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication2
{
    public partial class WebForm : System.Web.UI.Page
    {
        void Page_PreRender()
        {
            string uploadfolder = MapPath("~/newfolder/");
            DirectoryInfo dir = new DirectoryInfo(uploadfolder);
            Datalist1.DataSource = dir.GetFiles();
            Datalist1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        bool CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch(ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;

            }

        }
        protected void Button1_Click1(object sender,EventArgs e)
        {
            if (FileUpload.HasFile)
            {
                if (CheckFileType(FileUpload.FileName))
                {
                    FileUpload.SaveAs(MapPath("~/newfolder/" + FileUpload.FileName));
                }
            }
        }



 
    }
}