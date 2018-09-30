using DemoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace DemoFinal
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMessage.Visible = false;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.Name = TextBoxName.Text;
            student.Subject = TextBoxSubject.Text;
            student.City = TextBoxCity.Text;
            student.Marks = Convert.ToInt32(TextBoxMarks.Text);

            DAL.DataEntity entity = new DAL.DataEntity();
            bool entityAdded = entity.addStudent(student);

            if (entityAdded == true)
            {
                LabelMessage.Text = "Record added sucessfully";
                LabelMessage.ForeColor = System.Drawing.Color.Green;
                LabelMessage.Visible = true;

                TextBoxName.Text = "";
                TextBoxSubject.Text = "";
                TextBoxMarks.Text = "";
                TextBoxCity.Text = "";

            }
            else
            {
                LabelMessage.Text = "Some error occured. Please try again";
                LabelMessage.ForeColor = System.Drawing.Color.Red;
                LabelMessage.Visible = true;
                
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            TextBoxName.Text = "";
            TextBoxSubject.Text = "";
            TextBoxMarks.Text = "";
            TextBoxCity.Text = "";
        }
    }
}