using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class PurchaseDataAccess
    {
        public List<Purchase> getPurchase()
        {
            List<Purchase> listPurchase = new List<Purchase>();
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetPurchase", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listPurchase.Add(new Purchase()
                {
                    ProductID = Convert.ToInt32(rd["P_ID"].ToString()),
                    PurchaseID = Convert.ToInt32(rd["Purchase_ID"].ToString()),
                    PurchaseQty = Convert.ToInt32(rd["Qty"].ToString()),
                    PurchasePrice = Convert.ToInt32(rd["Price"].ToString())
                });
            }
            return listPurchase;
        }

        public void addPurchase(Purchase items)
        {
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddPurchase", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@qty", SqlDbType.Int).Value = items.PurchaseQty;
            cmd.Parameters.Add("@price", SqlDbType.Int).Value = items.PurchasePrice;
            cmd.Parameters.Add("@P_ID", SqlDbType.Int).Value = items.ProductID;
            cmd.ExecuteNonQuery();
        }
    }
}
