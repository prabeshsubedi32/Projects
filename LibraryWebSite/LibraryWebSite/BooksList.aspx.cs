﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWebSite
{
    public partial class BooksList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=PRABESH-PC\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("ListBooks", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            GridView1.DataSource = rd;
            GridView1.DataBind();

        }

    }
}