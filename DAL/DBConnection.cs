
using MySql.Data.MySqlClient;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class models a connection to 
    /// the RecipeApp application  DB.
    /// </summary>
    public class DBConnection
    {

        /// <summary>
        /// Get a connection object.
        /// </summary>
        /// <returns>SQLConnection to cs6232-g3 DB</returns>
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn;
            string connectionString =
                "Data Source=localhost;uid=root;" +
                "pwd=test1234!;database=recipe_app";
            conn = new MySqlConnection();

            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
            } catch (MySqlException ex)
            {
                
            }
            return conn;
        }
    }
}
