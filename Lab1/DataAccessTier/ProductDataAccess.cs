using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class ProductDataAccess
    {
        public List<Product> getProducts()
        {
            List<Product> listProd = new List<Product>();
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetProducts", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listProd.Add(new Product()
                {
                    ProductId = Convert.ToInt32(rd["P_ID"].ToString()),
                    ProductName = rd["productName"].ToString(),
                    ProductDesc = rd["p_Description"].ToString(),
                    ProductType = rd["P_Type"].ToString()
                });
            }
            return listProd;
        }

        public List<Product> getProductID()
        {
            List<Product> listProdID = new List<Product>();
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("getProductID", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listProdID.Add(new Product()
                {
                    ProductId = Convert.ToInt32(rd["P_ID"])
                });
            }
            return listProdID;
        }

        public void insertProduct(Product items)
        {
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            SqlCommand cmd = new SqlCommand("AddProduct", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_ID", SqlDbType.Int).Value = items.ProductId;
            cmd.Parameters.Add("@productName", SqlDbType.VarChar, 255).Value = items.ProductName;
            cmd.Parameters.Add("@p_Type", SqlDbType.VarChar, 50).Value = items.ProductType;
            cmd.Parameters.Add("@P_Description", SqlDbType.VarChar, 255).Value = items.ProductDesc;
            cmd.ExecuteNonQuery();
        }

        public void updateProduct(Product items)
        {
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            SqlCommand cmd = new SqlCommand("UpdateProduct", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_ID", SqlDbType.Int).Value = items.ProductId;
            cmd.Parameters.Add("@productName", SqlDbType.VarChar, 255).Value = items.ProductName;
            cmd.Parameters.Add("@p_Type", SqlDbType.VarChar, 50).Value = items.ProductType;
            cmd.Parameters.Add("@P_Description", SqlDbType.VarChar, 255).Value = items.ProductDesc;
            cmd.ExecuteNonQuery();

        }

        public void deleteProduct(int id)
        {
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            SqlCommand cmd = new SqlCommand("deleteProduct", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
    }


}
