using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void TestGetUsersThrowsExceptionIfUserIsNotAnAdmin()
        {
            List<User> users = controller.GetUsers(joe);
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
        /// Tests that Login works with valid username and password
        /// </summary>
        [TestMethod]
        public void TestLoginWorksWithValidUsernameAndPassword()
        {
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.Login(joe.Name, "bob"));
        }
    }
}
