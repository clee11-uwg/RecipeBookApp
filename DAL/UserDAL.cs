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
    }
}