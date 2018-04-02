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

            data.AddBooks(book);
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        { 
            LibraryData data = new LibraryData();
            BookItems items = new BookItems();
            if (data.getBookList().ToList().Where(x => x.Book_ID == Convert.ToInt32(txtBookID.Text)).Any())
            {
                data.RemoveBooks(Convert.ToInt32(txtBookID.Text));
            }
            else
            {
                errorText.Text = "Invalid Book_ID";
            }
        }
    }
}