using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DataEntity
    {
        public bool addStudent(Student student)
        {
            bool add ;
            string ConString = @"Data Source=PRATIK-PC\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConString);
            SqlCommand comm;
            conn.Open();
            comm = new SqlCommand("insert into students(Name,City,Subject,Marks) values('" + student.Name + "','" + student.City + "','" + student.Subject + "','" + student.Marks + "')", conn);
            try
            {
                comm.ExecuteNonQuery();
                add = true;          
            }
            catch (Exception ex)
            {
                add = false;
            }
            finally
            {
                conn.Close();               
            }
            return add;
        }
    }
}
