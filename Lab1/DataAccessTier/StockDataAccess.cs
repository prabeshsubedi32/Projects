using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class StockDataAccess
    {
        public void addStock(Stock items)
        {
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddStock", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@qty", SqlDbType.Int).Value = items.StockQty;
            cmd.Parameters.Add("@P_ID", SqlDbType.Int).Value = items.ProductID;
            cmd.ExecuteNonQuery();
        }

        public List<ReportClass> getStock()
        {
            List<ReportClass> listQty = new List<ReportClass>();
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetStock", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listQty.Add(new ReportClass()
                {
                    ProductID= Convert.ToInt32(rd["P_ID"]),
                    StockQty = Convert.ToInt32(rd["TotalQtry"]),
                    ProductName = rd["productName"].ToString()
                   
                });

            }

            return listQty;
        }


    }
}
