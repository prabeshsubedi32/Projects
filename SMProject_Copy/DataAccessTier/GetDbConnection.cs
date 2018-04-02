using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
   public  class GetDbConnection
    {
        public static string Connecton()
        {
            return "Data Source=PRABESH-PC\\SQLEXPRESS;Initial Catalog=SM;Integrated Security=True";

        }
    }
}
