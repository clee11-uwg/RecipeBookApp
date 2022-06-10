
using System.Data.SqlClient;

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
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=cs6232-g3;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
