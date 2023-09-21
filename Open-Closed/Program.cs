using Open_Closed.DbConnection;
using System.Runtime.CompilerServices;
    
namespace Open_Closed
{
    public class Program
    {
        static void Main(string[] args)
        {
            DBConnectionManager dBConnectionManager = new DBConnectionManager();

            dBConnectionManager.doConnect(new SqlServerConnection());
            dBConnectionManager.doConnect(new MySqlConnection());
            dBConnectionManager.doConnect(new PostgreSQLConnection());
        }
    }
}