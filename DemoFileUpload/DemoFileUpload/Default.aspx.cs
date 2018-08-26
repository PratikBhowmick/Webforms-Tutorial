using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoFileUpload
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);

                if(fileExtension.ToLower() != ".doc" && fileExtension.ToLower() != ".docx")
                {
                    Label1.Text = "File type having extension .doc or .docx are allowed";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if(fileSize>2097152)
                    {
                        Label1.Text = "Maximum file size (2MB) exceeded";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                        Label1.Text = "File uploaded succesfully";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }                    
                }                
            }
            else
            {
                Label1.Text = "Please upload a file";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}