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
            ProductDataAccess data = new ProductDataAccess();
            grdProducts.DataSource = data.getProducts();
            grdProducts.DataBind();
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
        }
    }
}