using DataHelper.Facade;
using System.Configuration;

namespace DataHelper.Factory
{
    public  static class DatabaseFactory
    {
        public static IDatabase GetInstance(bool useSingletone = false)
        {
            return new Database(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, useSingletone);
        }
    }
}
