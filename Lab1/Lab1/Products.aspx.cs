using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("CheckLogin.aspx?returnurl=Products.aspx");
            }
            if (!IsPostBack)
            {
                ProductDataAccess data = new ProductDataAccess();
                grdProducts.DataSource = data.getProducts();
                grdProducts.DataBind();
                ddlProductID.DataSource = data.getProductID();
                ddlProductID.DataValueField = "ProductId";
                ddlProductID.DataTextField = "ProductId";
                ddlProductID.DataBind();
                ddlProductID.Items.Insert(0, "Select");
            }

        }

        protected void btnAddProd_Click(object sender, EventArgs e)
        {
            ProductDataAccess data = new ProductDataAccess();
            Product items = new Product();
            items.ProductId = Convert.ToInt32(txtProductId.Text);
            items.ProductName = txtProductName.Text;
            items.ProductType = txtProductType.Text;
            items.ProductDesc = txtProductDes.Text;
            data.insertProduct(items);
            Response.Redirect("Products.aspx");
        }

        protected void btnUpdateProd_Click(object sender, EventArgs e)
        {
            ProductDataAccess data = new ProductDataAccess();
            Product items = new Product();
            items.ProductId = Convert.ToInt32(txtProductId.Text);
            items.ProductName = txtProductName.Text;
            items.ProductType = txtProductType.Text;
            items.ProductDesc = txtProductDes.Text;
            data.updateProduct(items);
            Response.Redirect("Products.aspx");
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
                txtProductId.Text = Convert.ToString(product.ProductId);
                txtProductName.Text = product.ProductName;
                txtProductType.Text = product.ProductType;
                txtProductDes.Text = product.ProductDesc;

            }
        }

        protected void btnDeleteProd_Click(object sender, EventArgs e)
        {
            ProductDataAccess data = new ProductDataAccess();
            data.deleteProduct(Convert.ToInt32(ddlProductID.SelectedValue));
            Response.Redirect("Products.aspx");
        }
    }
}