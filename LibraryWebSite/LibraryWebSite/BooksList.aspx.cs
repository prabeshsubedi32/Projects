using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryDataAccess;

namespace LibraryWebSite
{
    public partial class BooksList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LibraryData data = new LibraryData();
            GridView1.DataSource = data.getBookList();
            GridView1.DataBind();
        }

    }
}