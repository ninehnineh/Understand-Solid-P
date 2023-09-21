using Open_Closed.DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class DBConnectionManager
    {
        // Original
        //public void doSqlConnection(SqlServerConnection sqlServerConnection) => sqlServerConnection.doConnect();

        //public void doMySqlConnection(MySqlConnection mySqlConnection) => mySqlConnection.doConnect();

        // Change 1
        //public void doConnect(object Connection)
        //{
        //    if (Connection is SqlServerConnection sqlServerConnection)
        //    {
        //        sqlServerConnection.doConnect();
        //    }
        //    else if (Connection is MySqlConnection mySqlConnection) 
        //    {
        //        mySqlConnection.doConnect();
        //    }
        //}

        // Final change
        public void doConnect(IConnection connection)
        {
            connection.doConnect();
        }
    }
}
