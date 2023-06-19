using System.Data.SqlClient;

namespace KMU.Code.Extentions;

public static class ConnectionHandler
{
    private static string _connectionString = "Server=(LocalDb)\\MSSQLLocalDB;Database=KMU;Trusted_Connection=True;";

    private static SqlConnection? _connection = null;
    public static SqlConnection GetSqlConnection()
    {
        if (_connection is not null)
            return _connection;

        _connection = new(_connectionString);
        _connection.Open();
        return _connection;
    }
}