using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWebSite
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=PRABESH-PC\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from AdminList", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if ((txtUserName.Text == rd.GetString(0)) && (txtPassword.Text == rd.GetString(1)))
                {
                    Response.Redirect("BookListControl.aspx");
                }
            }
            txtMessage.Text = "Wrong UserName or Password";

         
        }
    }
}