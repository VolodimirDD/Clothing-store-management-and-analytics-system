using System.Data.SqlClient;

public class DatabaseHelper
{
    private SqlConnection sqlConnection;

    public DatabaseHelper()
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sasha\source\repos\ВКР\Database1.mdf;Integrated Security=True";
        sqlConnection = new SqlConnection(connectionString);
    }

    public void OpenConnection()
    {
        if (sqlConnection.State == System.Data.ConnectionState.Closed)
        {
            sqlConnection.Open();
        }
    }

    public void CloseConnection()
    {
        if (sqlConnection.State == System.Data.ConnectionState.Open)
        {
            sqlConnection.Close();
        }
    }

    public SqlConnection GetConnection()
    {
        return sqlConnection;
    }
}