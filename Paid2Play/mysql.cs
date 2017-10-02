using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace Paid2Play
{
    class mysql
    {
        public OdbcConnection MyConnection = new OdbcConnection("DRIVER={MySQL ODBC 5.3 UNICODE Driver}; Server=p2play.mysql.database.azure.com; Port=3306; Database=p2p; Uid=Ryan@p2play; Pwd=Paid2play;");
        public void connect()
        {
            MyConnection.Open();
            Console.WriteLine("\n !!! success, connected successfully !!!\n");

            //Display connection information
            Console.WriteLine("Connection Information:");
            Console.WriteLine("\tConnection String:" +
                              MyConnection.ConnectionString);
            Console.WriteLine("\tConnection Timeout:" +
                              MyConnection.ConnectionTimeout);
            Console.WriteLine("\tDatabase:" +
                              MyConnection.Database);
            Console.WriteLine("\tDataSource:" +
                              MyConnection.DataSource);
            Console.WriteLine("\tDriver:" +
                              MyConnection.Driver);
            Console.WriteLine("\tServerVersion:" +
                              MyConnection.ServerVersion);
        }
    }
}
