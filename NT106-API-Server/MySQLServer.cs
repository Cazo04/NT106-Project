using MySql.Data.MySqlClient;
using System.Text;

namespace NT106_WebServer
{
    public class MySQLServer
    {
        static List<string> connectionStrings = new List<string>
        {
            "server=cazomysql.mysql.database.azure.com;user=client;database=movies;port=3306;password=SCErxkiULsgpq4iEQYfp;"
        };
        public static MySqlConnection GetWorkingConnection()
        {
            foreach (var connStr in connectionStrings)
            {
                try
                {
                    var connection = new MySqlConnection(connStr);
                    connection.Open();  
                    Console.WriteLine($"Successfully connected to server: {connection.DataSource}");
                    return connection; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to connect to server: {ex.Message}");
                }
            }

            return null; 
        }
        public static string CheckAllServer()
        {
            StringBuilder builder1 = new StringBuilder();
            foreach (var connStr in connectionStrings)
            {
                try
                {
                    var connection = new MySqlConnection(connStr);
                    connection.Open();
                    builder1.Append($"Successfully connected to server: {connection.DataSource}");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    builder1.Append($"Failed to connect to server: {ex.Message}");
                }
            }
            return builder1.ToString();
        }
    }
}
