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
                                Name = reader["name"].ToString(),
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
        /// Finds if this username is all ready in use
        /// <param name="username">Name of User</param>
        /// <returns>If user name all ready exists</returns>
        public bool DoesUserNameExist(string username)
        {
            bool doesUserExist = false;
            string selectStatement = @"SELECT EXISTS
	                                    (SELECT *
	                                    FROM User
	                                    WHERE User.name = @username);";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        doesUserExist = Convert.ToBoolean(selectCommand.ExecuteNonQuery());
                    }
                }
            }
            return doesUserExist;
        }


        /// <summary>
        /// Registers a new user into the db
        /// </summary>
        /// <param name="newUser">The new user to register</param>
        /// <returns>Whether or not the new user was registered</returns>
        public bool RegisterUser(User newUser)
        {
            int result = -1;
            string selectStatement = @"INSERT INTO USER (name, password,is_admin) 
                                        VALUES (@username, @password, @is_admin)";
            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@username", newUser.Name);
                    selectCommand.Parameters.AddWithValue("@password", newUser.Password);
                    selectCommand.Parameters.AddWithValue("@is_admin", Convert.ToInt32(newUser.Is_Admin));

                    result = selectCommand.ExecuteNonQuery();
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
                                Name = reader["name"].ToString(),
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
        public string VerifyUser(string username)
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
        /// Changes a user's password
        /// <param name="user">The User whose password you're changing</param>
        /// <param name="newPassword">The new password</param>
        /// <returns>If the database was updated or not</returns>
        public bool ChangePassword(User user, string newPassword)
        {
            int result = -1;
            string selectStatement = @"UPDATE User
                                        SET amount = @password
                                        WHERE id = @id;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@password", newPassword);
                    selectCommand.Parameters.AddWithValue("@id", user.ID);

                    result = selectCommand.ExecuteNonQuery();
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

                    result = selectCommand.ExecuteNonQuery();
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

                    result = selectCommand.ExecuteNonQuery();
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