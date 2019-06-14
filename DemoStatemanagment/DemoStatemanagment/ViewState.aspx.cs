using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoStatemanagment
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Name"] != null)
            {
                ViewState["Name"] = TextBox1.Text;
                Label1.Text = ViewState["Name"].ToString();
            }
            else
            {
                ViewState["Name"] = "No Value in View State";
                Label1.Text = ViewState["Name"].ToString();
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {


        }
    }
}