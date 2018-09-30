using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_DataTransfer
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //QueryString-------------------------------------------------------------------------
            //Response.Redirect("~/Print.aspx?Name="+TextBoxName.Text+"&Email="+TextBoxEmail.Text);
            //------------------------------------------------------------------------------------

            //Cookies-----------------------------------------------------------------------------
            //HttpCookie myCookie = new HttpCookie("UserInfo");
            //myCookie["Name"] = TextBoxName.Text;
            //myCookie["EmailId"] = TextBoxEmail.Text;

            //Response.Cookies.Add(myCookie);

            //Response.Redirect("~/Print.aspx");
            //-------------------------------------------------------------------------------------

            //Session------------------------------------------------------------------------------
            //Session["Name"] = TextBoxName.Text;
            //Session["EmailId"] = TextBoxEmail.Text;
            //Response.Redirect("~/Print.aspx");
            //-------------------------------------------------------------------------------------
            Application["Name"] = TextBoxName.Text;
            Application["EmailId"] = TextBoxEmail.Text;
            Response.Redirect("~/Print.aspx");
        }
    }
}