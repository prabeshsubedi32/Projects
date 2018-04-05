using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class Stock
    {
        public int ProductID { get; set; }
        public int StockID { get; set; }
        public int StockQty { get; set; }
    }

    public class ReportClass
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int StockQty { get; set; }
    }
}

