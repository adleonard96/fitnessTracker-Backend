using MySql.Data;
using MySql.Data.MySqlClient;

namespace FitnessTracker.Data;

public class DatabaseConnection
{
    private DatabaseConnection() { }
    public string Server { get; set; }
    public string Database { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public MySqlConnection Connection { get; set; }

    private static DatabaseConnection? _instance = null;

    public static DatabaseConnection Instance()
    {
        _instance ??= new DatabaseConnection();
        return _instance;
    }

    public bool IsConnect()
    {
        if (Connection == null)
        {
            if (string.IsNullOrEmpty(Database))
                return false;
            string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, Database, UserName, Password);
            Connection = new MySqlConnection(connstring);
            Connection.Open();
        }

        return true;
    }

    public void Close()
    {
        Connection.Close();
    }
}