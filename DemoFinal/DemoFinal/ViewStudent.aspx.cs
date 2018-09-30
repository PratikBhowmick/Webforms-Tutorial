using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoFinal
{
    public partial class ViewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                gedata();
            }
        }

        public void gedata()
        {
            string ConString = @"Data Source=PRATIK-PC\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConString);
            SqlCommand comm;
            conn.Open();
            comm = new SqlCommand("select * from students", conn);                        
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            conn.Close();
        }
    }
}