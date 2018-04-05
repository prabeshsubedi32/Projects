using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class SalesDataAccess
    {
        public void addSales(Sales items)
        {
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddSales", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@qty", SqlDbType.Int).Value = items.SalesQty;
            cmd.Parameters.Add("@price", SqlDbType.Int).Value = items.SalesPrice;
            cmd.Parameters.Add("@P_ID", SqlDbType.Int).Value = items.ProductID;
            cmd.ExecuteNonQuery();
        }

    }
}
