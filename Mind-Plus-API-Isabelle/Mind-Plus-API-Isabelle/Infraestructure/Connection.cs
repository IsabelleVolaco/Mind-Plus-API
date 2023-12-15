using Dapper;
using MySql.Data.MySqlClient;

namespace Mind_Plus_API_Isabelle.Infraestructure
{
    public class Connection
    {
        protected string connectionString = "Server=localhost;Database=mindplus;User=root;Password=root;"; //trocar nome

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        protected async Task<int> Execute(string sql, object obj)
        {
            using (MySqlConnection con = GetConnection())
            {
                return await con.ExecuteAsync(sql, obj);  
            }
        }
    }
}
