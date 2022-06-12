
using MySql.Data;
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
            string connectionString =
                "Data Source=localhost;Initial Catalog=recipe_app;" +
                "Integrated Security=True";


            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
