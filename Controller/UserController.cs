using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using RecipeBookApp.Utility;
using System;
using System.Collections.Generic;

namespace RecipeBookApp.Controller
{

    /// <summary>
    /// Controller class connecting GUI with User queries
    /// </summary>
    public class UserController
    {
        private readonly UserDAL UserDAL;
        private static User currentLoginUser;

        /// <summary>
        /// Instantiate variables
        /// </summary>
        public UserController()
        {
            this.UserDAL = new UserDAL();
        }

        /// <summary>
        /// Set the user login details
        /// </summary>
        /// <param name="currentUser">User to set the currentUser to</param>
        public static void SetLoginUser(User currentUser)
        {
            currentLoginUser = currentUser;
        }

        /// <summary>
        /// Get the user login detsila
        /// </summary>
        /// <returns>The currentUser</returns>
        public static User GetLoginUser()
        {
            return currentLoginUser;
        }

        /// <see cref="UserDAL.GetUsers"/>
        /// <exception cref="UnauthorizedAccessException">If User is not an admin</exception>
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
        /// <exception cref="UnauthorizedAccessException">If incorrect username and password</exception>
        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(username))
            {
                throw new UnauthorizedAccessException("Failed to login");
            }
            String expected_password_hash = null;
            String given_password_hash = Crypt.SHA256_hash(password);

            try
            {
                expected_password_hash = this.UserDAL.VerifyUser(username);
                if (string.Equals(given_password_hash, expected_password_hash, StringComparison.OrdinalIgnoreCase))
                {
                    return this.UserDAL.GetUser(username);
                }
                else
                {
                    throw new UnauthorizedAccessException("Failed to login-Password is incorrect.");
                }
            }
            catch (NullReferenceException)
            {
                throw new UnauthorizedAccessException("Failed to login");
            }
        }

        /// <see cref="UserDAL.AddNewFavoriteRecipe(int, int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If user or recipe are less than 1</exception>
        /// <exception cref="NullReferenceException">If user or recipe otherwise do not exist</exception>
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

        /// <see cref="UserDAL.DeleteFavoriteRecipe(int, int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If user or recipe are less than 1</exception>
        /// <exception cref="NullReferenceException">If user or recipe otherwise do not exist</exception>
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

        /// <see cref="UserDAL.RegisterUser(User)"/>
        /// <exception cref="NullReferenceException">If the new user or its properties are null</exception>
        /// <exception cref="UnauthorizedAccessException">If the username all ready exists</exception>
        public bool AddUser(User newUser)
        {
            if (newUser is null || String.IsNullOrWhiteSpace(newUser.Name) ||
                String.IsNullOrWhiteSpace(newUser.Password))
            {
                throw new NullReferenceException("Missing user details for registration.");
            }

            if (this.UserDAL.GetUser(newUser.Name) !=null)
            {
                throw new UnauthorizedAccessException("Username already exists in the database.");
            }

            newUser.Password = Crypt.SHA256_hash(newUser.Password);
            return this.UserDAL.RegisterUser(newUser);
        }

        /// <see cref="UserDAL.ChangePassword(User, string)"/>
        /// <exception cref="NullReferenceException">If the passwords are null or empty</exception>
        /// <exception cref="UnauthorizedAccessException">If old password is incorrect</exception>
        public bool ChangeUserPassword(User user, string oldPassword, string newPassword)
        {
            if (String.IsNullOrWhiteSpace(oldPassword) || String.IsNullOrWhiteSpace(newPassword) || user == null)
            {
                throw new NullReferenceException("Cannot use empty passwords");
            }

            try
            {
                oldPassword = Crypt.SHA256_hash(oldPassword);
                string logInPassword = this.UserDAL.VerifyUser(user.Name);
                
                if (!string.Equals(logInPassword, oldPassword, StringComparison.OrdinalIgnoreCase))
                {
                    throw new UnauthorizedAccessException("Incorrect password");
                }
                newPassword = Crypt.SHA256_hash(newPassword);
                return this.UserDAL.ChangePassword(user, newPassword);
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Database error. Please try again.");
            }
        }
    }
}