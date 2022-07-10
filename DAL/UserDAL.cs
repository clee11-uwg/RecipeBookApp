using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using RecipeBookApp.Model;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB User table.
    /// </summary>
    public class UserDAL
    {
        /// <summary>
        /// This method to get the list of all Users known to the database
        /// </summary>
        /// <returns>List of Users known to the database</returns>
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            string selectStatement = @"SELECT user.id, user.name, user.is_admin
                                        FROM user;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Name = reader["Ethnicity"].ToString(),
                                Is_Admin = Convert.ToBoolean(Convert.ToInt32(reader["is_admin"]))
                            };

                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }

        /// <summary>
        /// Finds this User
        /// <param name="username">Name of User</param>
        /// <returns>User</returns>
        public User GetUser(string username)
        {
            User user = null;
            string selectStatement = @"SELECT user.id, user.name, user.is_admin
                                        FROM user
                                        WHERE user.name = @username;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new User
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Name = reader["Ethnicity"].ToString(),
                                Is_Admin = Convert.ToBoolean(Convert.ToInt32(reader["is_admin"]))
                            };
                        }
                    }
                }
            }
            return user;
        }

        /// <summary>
        /// Returns password hash for given user
        /// <param name="username">Name of User</param>
        /// <returns>Password hash</returns>
        public String VerifyUser(string username)
        {
            String hashed = null;
            string selectStatement = @"SELECT user.password
                                    FROM user
                                    WHERE user.name = @username;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hashed = reader["password"].ToString();
                        };
                    }
                }
            }
            return hashed;
        }

        /// <summary>
        /// Adds a new favorite recipe for the user
        /// <param name="userID">Id of the User</param>
        /// <param name="recipeID">Id of the Recipe</param>
        /// <returns>If the database was updated or not</returns>
        public bool AddNewFavoriteRecipe(int userID, int recipeID)
        {
            int result = -1;
            string selectStatement = @"INSERT INTO User_has_favorite_Recipes (userID, recipeID)
                                        VALUES (@userID, @recipeID);";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userID", userID);
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);

                    connection.Open();
                    result = selectCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Deletes a favorite recipe for the user
        /// <param name="userID">Id of the User</param>
        /// <param name="recipeID">Id of the Recipe</param>
        /// <returns>If the database was updated or not</returns>
        public bool DeleteFavoriteRecipe(int userID, int recipeID)
        {
            int result = -1;
            string selectStatement = @"DELETE FROM User_has_favorite_Recipes
                                        WHERE userID = @userID AND recipeID = @userID;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userID", userID);
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);

                    connection.Open();
                    result = selectCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}