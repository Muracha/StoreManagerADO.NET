using System.Collections.Generic;

namespace StoreManager.Repositories
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
        public static IEnumerable<int> Permissions { get; set; } = new List<int>();
        public static object Record { get; set; }
    }
}
