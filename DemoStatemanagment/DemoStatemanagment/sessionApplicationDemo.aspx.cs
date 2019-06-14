using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoStatemanagment
{
    public partial class sessionApplicationDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Count"] != null) //Lets retrieve, increase and store again
            {
                Label3.Text = Request.QueryString["Count"];
            }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {


            int noOfRedirection = 0;

            if (Request.QueryString["Count"] != null) //Lets retrieve, increase and store again
            {
                noOfRedirection = Convert.ToInt32(Request.QueryString["Count"]) + 1;
            }
            else //First postback, lets store the info
            {
                noOfRedirection = 1;
            }

            Response.Redirect("sessionApplicationDemo.aspx?Count=" + noOfRedirection);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application.Lock();
            Application["Count"] = Convert.ToInt32(Application["Count"]) + 1;
            Application.UnLock();
            Label1.Text = Application["Count"].ToString();

            //Store in Session State --------------------------------------------------------------          
            Session["Count"] = Convert.ToInt32(Session["Count"]) + 1;
            Label2.Text = Session["Count"].ToString();

        }
    }
}