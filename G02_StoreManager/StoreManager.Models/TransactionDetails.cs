using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Models
{
    public class TransactionDetails
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public decimal SellPrice { get; set; }
        public decimal Quantity { get; set; }
    }
}
