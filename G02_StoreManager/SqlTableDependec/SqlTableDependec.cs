using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTableDependec
{
    public class SqlTableDependec<T1,T2>
    {

        public void StartTableDependecy()
        {
            SqlTableDependec<T1> d=new SqlTableDependec<T1,T2>();
        }
    }
}
