using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }
}
