using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessTier;

namespace Lab1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //UserDataAccess data = new UserDataAccess();
            SqlConnection cnn = new SqlConnection("Data Source=PRABESH-PC\\SQLEXPRESS;Initial Catalog=SM;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from userInfo", cnn);
            cnn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            GridView1.DataSource = rd;
            GridView1.DataBind();
        }
    }
}