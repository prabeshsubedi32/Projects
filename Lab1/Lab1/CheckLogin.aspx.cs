using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Lab1
{
    public partial class CheckLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=PRABESH-PC\\SQLEXPRESS;Initial Catalog=SM;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from userInfo", cnn);
            cnn.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read()){
                if((txtUsername.Text == rd.GetString(1)) && (txtPassword.Text == rd.GetString(2))){
                    Response.Redirect("Home.aspx");
                }
            }
            errorMessage.Text = "Wrong UserName or Password";

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}