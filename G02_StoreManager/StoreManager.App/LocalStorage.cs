using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.App
{
    public static class LocalStorage
    {
        /// <summary>
        /// ინახავს ავტორიზებული მომხმარებლის იდენთიფიკატორს.
        /// </summary>
        /// 

        public static int LoggedUserID { get; set; }

        /// <summary>
        /// ინახავს ავტორიზებული მომხმარებლის უფლებების კოდებს.
        /// </summary>
        /// 
        public static IEnumerable<object> Permissions { get; set; } = new List<object>();
    }
}
