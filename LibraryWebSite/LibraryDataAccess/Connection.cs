using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryDataAccess
{
    public class Connection
    {
        public static string getConnection()
        {
            return ("Data Source=PRABESH-PC\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True");
        }

    }
}
