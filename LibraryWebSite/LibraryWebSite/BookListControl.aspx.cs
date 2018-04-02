using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWebSite
{
    public partial class BookListControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                LibraryData data = new LibraryData();
                ddlBookList.DataSource = data.getBookList();
                ddlBookList.DataValueField = "Book_ID";
                ddlBookList.DataTextField = "Book_ID";
                ddlBookList.DataBind();
                ddlBookList.Items.Insert(0, "Select");
            }
           // Response.Redirect()
        }

        protected void btnBooksList_Click(object sender, EventArgs e)
        {
            Response.Redirect("BooksList.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            LibraryData data = new LibraryData();
            BookItems book = new BookItems();

            book.BooksName = txtBooksName.Text;
            book.Book_ID = Convert.ToInt32(txtBookID.Text);
            data.addBooks(book);
            Response.Redirect("BookListControl.aspx");
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        { 
            LibraryData data = new LibraryData();
           // BookItems items = new BookItems();
            if (data.getBookList().ToList().Where(x => x.Book_ID == Convert.ToInt32(txtBookID.Text)).Any())
            {
                data.removeBooks(Convert.ToInt32(txtBookID.Text));
            }
            else
            {
                errorText.Text = "Invalid Book_ID";
            }
            Response.Redirect("BookListControl.aspx");
        }

        protected void ddlBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ddlBookList.SelectedValue != "Select")
           // {
                int selectedId = Convert.ToInt32(ddlBookList.SelectedValue);
                LibraryData data = new LibraryData();
                var user = data.getBookList().ToList().Select(x => new BookItems()
                {
                    BooksName = x.BooksName,
                    Book_ID = x.Book_ID
                }).ToList().Where(x => x.Book_ID == selectedId).FirstOrDefault();
                txtBooksName.Text = user.BooksName;
                txtBookID.Text = Convert.ToString(user.Book_ID);
           // }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryData data = new LibraryData();
            BookItems items = new BookItems();
            items.BooksName = txtBooksName.Text;
            items.Book_ID = Convert.ToInt32(txtBookID.Text);
            data.updateBooks(items);
            Response.Redirect("BookListControl.aspx");
        }
    }
}