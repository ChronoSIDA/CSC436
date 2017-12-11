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

        public static MySqlConnection MyConnection = new MySqlConnection("Server= csc436.mysql.database.azure.com; Port=3306; Database=p2p; Uid=Evan@csc436; Pwd=password1234!;");
        public MySqlCommand cmd = new MySqlCommand("", MyConnection);
        public MySqlDataReader reader;
        public void connect(){
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
            decimal z = 0;
            addAccount(x, z);
        }

        public void addAccount(string x, decimal y)
        {
            string text = "INSERT INTO account VALUES('" + x + "','" + y + "')";
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
        public decimal getCredits(string user)
        {
            decimal x;
            string text = "select credits from account where email = '" + user + "';";
            cmd.CommandText = text;
            reader = cmd.ExecuteReader();
            reader.Read();
            x = reader.GetDecimal("credits");  
            MyConnection.Close();
            return x;
        }
        public void setPassword(string user, string pass)
        {
            string text = "UPDATE users SET password='"+pass+"'WHERE email = '"+user+"';";
            cmd.CommandText = (text);
            cmd.ExecuteNonQuery();
            MyConnection.Close();

        }
        public void setCredits(string user, decimal amount)
        {
            MyConnection.Open();
            string text = "UPDATE account SET credits='" + amount + "'WHERE email = '" + user + "';";
            cmd.CommandText = (text);
            cmd.ExecuteNonQuery();
            MyConnection.Close();
        }
        public void addActivity(String name, String date)
        {
          
            string text = "INSERT INTO activity VALUES('" + DBNull.Value +"','"+ name + "','" + date + "')";
            cmd.CommandText = (text);
            cmd.ExecuteNonQuery();
            MyConnection.Close();
        }

        public string getGame(int id)
        {
            string text = "select name, creator, description from games where id = '" + id + "';";
            cmd.CommandText = text;
            reader = cmd.ExecuteReader();
            reader.Read();
            string name = reader["name"].ToString();
            string creator = reader["creator"].ToString();
            string description = reader["description"].ToString();
            string str = (name + "1" + creator + "1" + description + "1");
            reader.Close();
            return str;
            
        }
        public string gameSearch(string name) {
            string text = "select name, creator, description from games where name LIKE '"+"%" + name + "%" + "';";
            cmd.CommandText = text;
            reader = cmd.ExecuteReader();
            reader.Read();
            string n = reader["name"].ToString();
            string creator = reader["creator"].ToString();
            string description = reader["description"].ToString();
            string str = (n + "1" + creator + "1" + description + "1");
            reader.Close();
            return str;
        }

        public string getActivity()
        {
            string data = "";
            for (int i = 0; i <= 5; i++)
            {
                string text = "select * from activity WHERE id=(SELECT max(id) -" + i + " FROM activity)";
                cmd.CommandText = text;
                reader = cmd.ExecuteReader();
                reader.Read();
                data += (reader.GetString("name") + "             " + reader.GetString("date") + "\n");
                reader.Close();
            }
            MyConnection.Close();
            return data;
        }
    }
}
