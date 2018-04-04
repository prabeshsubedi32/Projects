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

        public List<Stock> getStockQty()
        {
            List<Stock> listQty = new List<Stock>();
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetQty", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listQty.Add(new Stock()
                {
                    StockQty= Convert.ToInt32(rd["Qty"])
                });

            }

            return listQty;
        }


    }
}
