using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Models
{
    public class ContactInfo
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int ContactType { get; set; }
        public string ContactData { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
