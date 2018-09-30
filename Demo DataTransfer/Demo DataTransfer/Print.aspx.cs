using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_DataTransfer
{
    public partial class Print : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Query String---------------------------------
            //LabelName.Text = Request.QueryString["Name"];
            //LabelEmail.Text = Request.QueryString["Email"];
            //----------------------------------------------

            //Cookies---------------------------------------
            //HttpCookie cookie = Request.Cookies["UserInfo"];
            //if(cookie["Name"]!=null)
            //{
            //    LabelName.Text = cookie["Name"];
            //}
            //if (cookie["EmailId"] != null)
            //{
            //    LabelName.Text = cookie["EmailId"];
            //} 
            //-----------------------------------------------      

            //Session----------------------------------------
            //LabelName.Text = Session["Name"].ToString();
            //LabelEmail.Text = Session["EmailId"].ToString();
            //----------------------------------------------

            //ApplicationState----------------------------------
            LabelName.Text = Application["Name"].ToString();
            LabelEmail.Text = Application["EmailId"].ToString();
            //---------------------------------------------------

        }
    }
}