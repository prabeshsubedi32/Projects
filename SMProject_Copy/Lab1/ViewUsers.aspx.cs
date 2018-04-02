using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class ViewUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDataAccess data = new UserDataAccess();
            GridView1.DataSource = data.getUsers();
            GridView1.DataBind();
        }
    }
}