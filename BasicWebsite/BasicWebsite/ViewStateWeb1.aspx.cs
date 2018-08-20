using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebsite
{
    public partial class ViewStateWeb1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Application["count"] != null)
                {
                    TextBox1.Text = Application["count"].ToString();
                }
                else
                {
                    TextBox1.Text = "0";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Application["count"] != null)
            {
                int result = Convert.ToInt32(Application["count"])+1;
                TextBox1.Text = result.ToString();
                Application["count"] = TextBox1.Text;
            }
            else
            {
                TextBox1.Text = (int.Parse(TextBox1.Text) + 1).ToString();
                Application["count"] = TextBox1.Text;
            }
        }
    }
}