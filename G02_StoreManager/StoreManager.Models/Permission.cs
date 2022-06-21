using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Models
{
    public class Permission
    {
        public int ID { get; set; }
        public string PermissionName { get; set; }
        public int PermissionCode { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
