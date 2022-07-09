using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using RecipeBookApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBookApp.Controller
{

    /// <summary>
    /// Controller class connecting GUI with User queries
    /// </summary>
    public class UserController
    {
        private readonly UserDAL UserDAL;

        /// <summary>
        /// Instantiate variables
        /// </summary>
        public UserController()
        {
            this.UserDAL = new UserDAL();
        }

        /// <summary>
        /// Gets all Users from the database table.
        /// </summary>
        /// <returns>List of all Users from database </returns>
        public List<User> GetUsers(User admin)
        {
            if (admin.Is_Admin == false)
            {
                throw new UnauthorizedAccessException(admin.Name + " is not an admin");
            }
            return this.UserDAL.GetUsers();
        }

        /// <summary>
        /// Logins the user by username and password
        /// </summary>
        /// <param name="username">Name of User</param>
        /// <param name="password">Password of User</param>
        /// <returns>The User</returns>
        public User Login(string username, string password)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
            {
                throw new UnauthorizedAccessException("Failed to login");
            }
            String expected_password_hash = null;
            String given_password_hash = Crypt.SHA256_hash(password);

            try
            {
                expected_password_hash = this.UserDAL.VerifyUser(username);
            }
            catch (NullReferenceException)
            {
                throw new UnauthorizedAccessException("Failed to login");
            }

            if (given_password_hash.Equals(expected_password_hash))
            {
                return this.UserDAL.GetUser(username);
            }
            else
            {
                throw new UnauthorizedAccessException("Failed to login");
            }
        }



    }
}