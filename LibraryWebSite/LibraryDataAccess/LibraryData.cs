using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class LibraryData
    {
        public List<BookItems> getBookList()
        {
            List<BookItems> listItems = new List<BookItems>();
            SqlConnection conn = new SqlConnection(Connection.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("ListBooks", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listItems.Add(new BookItems
                {
                    BooksName = rd["NameOfBooks"].ToString(),
                    Book_ID = Convert.ToInt32(rd["Book_ID"].ToString())
                });

            }
            return listItems;
        }

        public List<AdminList> getAdminList()
        {
            List<AdminList> listItems = new List<AdminList>();
            SqlConnection conn = new SqlConnection(Connection.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("listAdmin", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listItems.Add(new AdminList()
                {
                    UserName = rd["UserName"].ToString(),
                    Password = rd["UserPassword"].ToString()
                });

            }
            return listItems;
        }

        public List<BookItems> getBookID()
        {
            List<BookItems> listUser = new List<BookItems>();
            SqlConnection conn = new SqlConnection(Connection.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("getBookID", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listUser.Add(new BookItems()
                {
                    Book_ID = Convert.ToInt32(rd["Book_ID"])
                });

            }
            return listUser;
        }

        public void addBooks(BookItems items)
        {
            SqlConnection conn = new SqlConnection(Connection.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddBooks", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@bn", SqlDbType.VarChar, 50).Value = items.BooksName;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = items.Book_ID;

            cmd.ExecuteNonQuery();
        }

        public void removeBooks(int id)
        {
            SqlConnection conn = new SqlConnection(Connection.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("delBooks", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();

        }

        public void updateBooks(BookItems items)
        {
            SqlConnection conn = new SqlConnection(Connection.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("updateBooks", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@bn", SqlDbType.VarChar,50).Value =items.BooksName;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value =items.Book_ID;
            cmd.ExecuteNonQuery();

        }

    }
}

