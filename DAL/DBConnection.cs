using System.Data.SQLite;
using System.Configuration;

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
        /// <returns>SQLite Connection to recipe_app db</returns>
        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn;
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SQLiteConnection(connectionString);
            /*try
            {
                conn.Open();
            }
            catch (SQLiteException sle)
            {

            }*/
            return conn;
        }
    }
}
