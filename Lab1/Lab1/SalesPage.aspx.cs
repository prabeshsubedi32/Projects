using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class SalesPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"]==null)
            {
                Response.Redirect("CheckLogin.aspx?returnurl=SalesPage.aspx");
            }
            if (!IsPostBack)
            {

                ProductDataAccess data = new ProductDataAccess();
                
                ddlProductID.DataSource = data.getProductID();
                ddlProductID.DataValueField = "ProductID";
                ddlProductID.DataTextField = "ProductID";
                ddlProductID.DataBind();
                ddlProductID.Items.Insert(0, "Select");

            }
        }

        protected void ddlProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProductID.SelectedValue != "Select")
            {
                int selectedId = Convert.ToInt32(ddlProductID.SelectedValue);
                ProductDataAccess data = new ProductDataAccess();
                StockDataAccess data1 = new StockDataAccess();
                //var test = data.getUsers();
                var product = data.getProducts().ToList().Select(x => new Product()
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductDesc = x.ProductDesc,
                    ProductType = x.ProductType
                }).ToList().Where(x => x.ProductId == selectedId).FirstOrDefault();
                txtProductID.Text = Convert.ToString(product.ProductId);
                txtProductName.Text = product.ProductName;
                txtProductType.Text = product.ProductType;
                txtProductDes.Text = product.ProductDesc;

                var qty = data1.getStock().ToList().Select(x => new ReportClass()
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    StockQty = x.StockQty
                }).ToList().Where(x => x.ProductID == selectedId).FirstOrDefault();
                txtTotalQty.Text = Convert.ToString(qty.StockQty);

            }
        }

        protected void btnSales_Click(object sender, EventArgs e)
        {
            SalesDataAccess data = new SalesDataAccess();
            StockDataAccess data1 = new StockDataAccess();
            Sales items = new Sales();

            items.ProductID = Convert.ToInt32(txtProductID.Text);
            items.SalesQty = Convert.ToInt32(txtQty.Text);
            items.SalesPrice = Convert.ToInt32(txtPrice.Text);

            var qty = data1.getStock().ToList().Select(x => new ReportClass()
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                StockQty = x.StockQty
            }).ToList().Where(x => x.ProductID == Convert.ToInt32(txtProductID.Text))
            .FirstOrDefault();

            if (Convert.ToInt32(txtQty.Text) >= Convert.ToInt32(qty.StockQty))
            {
                btnSales.Text = "Not enough in Stock";
            }
            else
            {
                data.addSales(items);
            }


        }
    }
}