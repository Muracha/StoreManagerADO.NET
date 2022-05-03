using DataHelper.Facade;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase GetInstance(bool useSingletone = false)
        {
            return new Database(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, useSingletone);
        }
    }
}
