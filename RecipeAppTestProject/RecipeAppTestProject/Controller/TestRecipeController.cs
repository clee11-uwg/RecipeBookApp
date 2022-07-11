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
    /// Class containing test methods for Type of Meal Controller
    /// </summary>
    [TestClass]
    public class TestRecipeController
    {
        RecipeController controller;

        /// <summary>
        /// Initialize RecipeController used in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new RecipeController();
        }

        /// <summary>
        /// Tests that GetRecipe(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetRecipeByRecipeIDThrowsExceptionIfZero()
        {
            Recipe recipe = controller.GetRecipe(0);
        }

        /// <summary>
        /// Tests that GetRecipe(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetRecipeByRecipeIDThrowsExceptionIfNegative()
        {
            Recipe recipe = controller.GetRecipe(-1);
        }

        /// <summary>
        /// Tests that GetRecipeSearch(string) throws error if string is null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetRecipeSearchThrowsExceptionIfNull()
        {
            List<Recipe> recipes = controller.GetRecipeSearch(null);
        }

        /// <summary>
        /// Tests that GetRecipeSearch(string) throws error if string is empty
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetRecipeSearchThrowsExceptionIfEmpty()
        {
            List<Recipe> recipes = controller.GetRecipeSearch("");
        }

        /// <summary>
        /// Tests that GetFavoriteRecipes(int) throws exception if int is less than 1
        /// </summary>
        [TestMethod]
        public void TestGetFavoriteRecipeThrowsExceptionIfUserIDIsLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetFavoriteRecipes(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetFavoriteRecipes(-1));
        }
    }
}
