using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class ReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("CheckLogin.aspx?returnurl=ReportPage.aspx");
            }
            StockDataAccess data = new StockDataAccess();
            GridView1.DataSource = data.getStock();
            GridView1.DataBind();

        }
    }
}