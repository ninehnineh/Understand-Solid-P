using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.DbConnection
{
    public class PostgreSQLConnection : IConnection
    {
        public void doConnect() => Console.WriteLine("Connect to PostgreSQL Server");

    }
}
