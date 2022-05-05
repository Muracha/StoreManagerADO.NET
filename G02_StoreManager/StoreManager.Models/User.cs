using System;

namespace StoreManager.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
