using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class Purchase
    {
        public int ProductID { get; set; }
        public int PurchaseID { get; set; }
        public int PurchaseQty { get; set; }
        public int PurchasePrice { get; set; }
    }
}
