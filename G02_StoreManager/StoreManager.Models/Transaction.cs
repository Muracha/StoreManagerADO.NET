using System;

namespace StoreManager.Models  
{
    public class Transaction
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
