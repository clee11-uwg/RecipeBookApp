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

        /// <summary>
        /// Adds a new favorite recipe for the user
        /// </summary>
        /// <param name="userID">ID of the user</param>
        /// <param name="recipeID">ID of the recipe</param>
        /// <returns>Whether or not the recipe was added as a favorite</returns>
        public bool AddNewFavoriteRecipe(int userID, int recipeID)
        {
            if (userID < 1 || recipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Must be a valid user and recipe id");
            }
            try
            {
                return this.UserDAL.AddNewFavoriteRecipe(userID, recipeID);
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("User or Recipe does not exist. Please try again");
            }
        }

        /// <summary>
        /// Deletes a favorite recipe for the user
        /// </summary>
        /// <param name="userID">ID of the user</param>
        /// <param name="recipeID">ID of the recipe</param>
        /// <returns>Whether or not the recipe was deleted as a favorite</returns>
        public bool DeleteFavoriteRecipe(int userID, int recipeID)
        {
            if (userID < 1 || recipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Must be a valid user and recipe id");
            }
            try
            {
                return this.UserDAL.DeleteFavoriteRecipe(userID, recipeID);
            }
            catch
            {
                throw new NullReferenceException("User or Recipe does not exist. Please try again");
            }
        }

    }
}