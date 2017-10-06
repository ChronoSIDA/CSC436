using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Paid2Play
{
    class mysql
    {
        
        public static MySqlConnection MyConnection = new MySqlConnection("Server=p2play.mysql.database.azure.com; Port=3306; Database=p2p; Uid=Ryan@p2play; Pwd=Paid2play;");
        public MySqlCommand cmd = new MySqlCommand("",MyConnection);
        public MySqlDataReader reader;
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
            Console.WriteLine("\tServerVersion:" +
                              MyConnection.ServerVersion);
        }
        public void addUser(string x, string y)
        {
            string text = "INSERT INTO users VALUES('" + x + "','" + y + "')";
            cmd.CommandText = (text);
            cmd.ExecuteNonQuery();
            MyConnection.Close();
        }

        public bool verifyUser(string user, string pass)
        {
            string text = "select password from users where email = '" + user + "';";
            cmd.CommandText = text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == pass)
                {
                    MyConnection.Close();
                    return true;
                    
                }
                else
                {
                    MyConnection.Close();
                    return false;
                    
                }
                
            }
            return false;

        }
        public void CloseConnect()
        {
            MyConnection.Close();
        }
    }
}
