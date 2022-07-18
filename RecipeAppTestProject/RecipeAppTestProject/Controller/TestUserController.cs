using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Controller;
using RecipeBookApp.Model;

namespace RecipeAppTestProject.Controller
{
    /// <summary>
    /// Class containing test methods for User Controller
    /// </summary>
    [TestClass]
    public class TestUserController
    {
        UserController controller;
        User joe;
        User fake;

        /// <summary>
        /// Initialize UserController and User to use in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new UserController();
            joe = new User
            {
                ID = 6,
                Name = "joe",
                Is_Admin = false
            };
            fake = new User
            {
                ID = 101,
                Name = "Fake",
                Is_Admin = false
            };
        }

        /// <summary>
        /// Tests that GetUsers throws errors if User is not an admin
        /// </summary>
        [TestMethod]
        public void TestGetUsersThrowsExceptionIfUserIsNotAnAdmin()
        {
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.GetUsers(joe));
        }

        /// <summary>
        /// Tests that Login throws error if Username and Password are blank
        /// </summary>
        [TestMethod]
        public void TestLoginThrowsExceptionIfInputIsNullOrEmpty()
        {
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.Login("", "password"));
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.Login("user", ""));
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.Login(null, "password"));
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.Login("user", null));
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.Login("  ", "password"));
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.Login("user", "  "));
        }

        /// <summary>
        /// Tests that Login throws error if Username is not in the system
        /// </summary>
        [TestMethod]
        public void TestLoginThrowsExceptionIfUserIsNotInTheSystem()
        {
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.Login(fake.Name, "password"));
        }

        /// <summary>
        /// Tests that Login throws error if bad username and password
        /// </summary>
        [TestMethod]
        public void TestLoginThrowsExceptionIfBadUsernameAndPasswordCombination()
        {
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.Login(joe.Name, "incorrect"));
        }

        /// <summary>
        /// Tests that Add and Delete favorites recipes don't work with ids below 1
        /// </summary>
        [TestMethod]
        public void TestAddDeleteFavoriteRecipeThrowsExceptionIfIDsAreBelowOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.AddNewFavoriteRecipe(0, 1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.AddNewFavoriteRecipe(-1, 1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.AddNewFavoriteRecipe(1, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.AddNewFavoriteRecipe(1, -1));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.DeleteFavoriteRecipe(0, 1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.DeleteFavoriteRecipe(-1, 1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.DeleteFavoriteRecipe(1, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.DeleteFavoriteRecipe(1, -1));
        }

        /// <summary>
        /// Tests that Add and Delete favorites recipes don't work with invalid user/recipe combos
        /// </summary>
        [TestMethod]
        public void TestAddDeleteFavoriteRecipeThrowsExceptionIfInvalidCombination()
        {
            Assert.ThrowsException<NullReferenceException>(() => controller.AddNewFavoriteRecipe(101, 37));
            Assert.ThrowsException<NullReferenceException>(() => controller.AddNewFavoriteRecipe(37, 101));
            Assert.ThrowsException<NullReferenceException>(() => controller.AddNewFavoriteRecipe(1001, 370));

            Assert.ThrowsException<NullReferenceException>(() => controller.DeleteFavoriteRecipe(102, 38));
            Assert.ThrowsException<NullReferenceException>(() => controller.DeleteFavoriteRecipe(587, 107));
            Assert.ThrowsException<NullReferenceException>(() => controller.DeleteFavoriteRecipe(1002, 377));
        }

        /// <summary>
        /// Tests that Register User throws exceptions when given data is null or empty
        /// </summary>
        [TestMethod]
        public void TestRegisterUserThrowsExceptionIfDataIsNullOrEmpty()
        {
            User newUser = new User();
            Assert.ThrowsException<NullReferenceException>(() => controller.AddUser(newUser));

            newUser.Name = "bob";
            Assert.ThrowsException<NullReferenceException>(() => controller.AddUser(newUser));

            newUser.Name = null;
            newUser.Password = "lol";
            Assert.ThrowsException<NullReferenceException>(() => controller.AddUser(newUser));

            newUser.Name = "";
            Assert.ThrowsException<NullReferenceException>(() => controller.AddUser(newUser));

            newUser.Name = "  ";
            Assert.ThrowsException<NullReferenceException>(() => controller.AddUser(newUser));

            newUser.Name = "bob";
            newUser.Password = "";
            Assert.ThrowsException<NullReferenceException>(() => controller.AddUser(newUser));

            newUser.Name = "bob";
            newUser.Password = "  ";
            Assert.ThrowsException<NullReferenceException>(() => controller.AddUser(newUser));
        }

        /**
        /// <summary>
        /// Tests the RegisterUser throws exception if user all ready exists
        /// </summary>
        [TestMethod]
        public void TestRegisterUserThrowsExceptionIfUserNameAllReadyExists()
        {
            User faker = new User
            {
                ID = -1,
                Name = "greg",
                Password = "faker",
                Is_Admin = false
            };
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.AddUser(faker));
        }
        */

        /// <summary>
        /// Change Passwords through exceptions if parameters are null or empty
        /// </summary>
        [TestMethod]
        public void TestChangePasswordThrowsExceptionIfParametersAreNullOrEmpty()
        {
            Assert.ThrowsException<NullReferenceException>(() => controller.ChangeUserPassword(null, "gobble", "gobble"));
            Assert.ThrowsException<NullReferenceException>(() => controller.ChangeUserPassword(joe, null, "gobble"));
            Assert.ThrowsException<NullReferenceException>(() => controller.ChangeUserPassword(joe, "gobble", null));

            Assert.ThrowsException<NullReferenceException>(() => controller.ChangeUserPassword(joe, "", "gobble"));
            Assert.ThrowsException<NullReferenceException>(() => controller.ChangeUserPassword(joe, "gobble", ""));

            Assert.ThrowsException<NullReferenceException>(() => controller.ChangeUserPassword(joe, "  ", "gobble"));
            Assert.ThrowsException<NullReferenceException>(() => controller.ChangeUserPassword(joe, "gobble", "  "));
        }

        /**
        /// <summary>
        /// Tests that Change Password throws exception if one inputs the wrong old password
        /// </summary>
        [TestMethod]
        public void TestChangePasswordThrowsExceptionIfInputIncorrectOldPassword()
        {
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.ChangeUserPassword(joe, "gobbledegook", "gobble"));
        }
        */
    }
}
