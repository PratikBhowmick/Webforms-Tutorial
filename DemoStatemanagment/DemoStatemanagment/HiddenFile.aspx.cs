using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoStatemanagment
{
    public partial class HiddenFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (HiddenField1.Value != null)
                {
                    int val = Convert.ToInt32(HiddenField1.Value) + 1;
                    HiddenField1.Value = val.ToString();
                    Label1.Text = val.ToString();
                }
                else
                {


                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {


        }
    }
}