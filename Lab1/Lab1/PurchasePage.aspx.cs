using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class PurchasePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            int totalQty = 0;
            ProductDataAccess data1 = new ProductDataAccess();
            PurchaseDataAccess data = new PurchaseDataAccess();
            StockDataAccess stockData = new StockDataAccess();
            Purchase items = new Purchase();
            Stock stockItems = new Stock();

            items.ProductID = Convert.ToInt32(txtProductID.Text);
            items.PurchaseQty = Convert.ToInt32(txtQty.Text);
            items.PurchasePrice = Convert.ToInt32(txtPrice.Text);
            data.addPurchase(items);

            if (data1.getProductID().ToList().Where(x => (x.ProductId == Convert.ToInt32(txtProductID.Text))).Any())
            {
                totalQty = (Convert.ToInt32(stockData.getStockQty().ToList()
                    .Where(x => x.StockQty == Convert.ToInt32(txtQty.Text)).ToList()
                    .Select(xx => Convert.ToInt32(xx.StockQty))
                    .FirstOrDefault().ToString()) + (Convert.ToInt32(txtQty.Text)));
            }
            else
            {
                totalQty = Convert.ToInt32(txtQty.Text);
            }

            stockItems.ProductID = Convert.ToInt32(txtProductID.Text);
            stockItems.StockQty = totalQty;
            stockData.addStock(stockItems);
            Response.Redirect("PurchasePage.aspx");
            


        }
    }


}