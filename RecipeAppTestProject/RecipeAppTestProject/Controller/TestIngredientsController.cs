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
    /// Class containing test methods for Ingredients Controller
    /// </summary>
    [TestClass]
    public class TestIngredientsController
    {
        IngredientsController controller;

        /// <summary>
        /// Initialize IngredientsController used in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new IngredientsController();
        }

        /// <summary>
        /// Tests that GetIngredients(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetIngredientsByRecipeIDThrowsExceptionIfZero()
        {
            List<Ingredient> ingredients = controller.GetIngredient(0);
        }

        /// <summary>
        /// Tests that GetIngredients(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetIngredientsByRecipeIDThrowsExceptionIfNegative()
        {
            List<Ingredient> ingredients = controller.GetIngredient(-1);
        }

        /// <summary>
        /// Get Ingredieny by Name throws exception if name is null or empty
        /// </summary>
        [TestMethod]
        public void TestGetIngredientByNameThrowsExceptionIfNameIsNullOrEmpty()
        {
            Assert.ThrowsException<NullReferenceException>(() => controller.GetIngredientByIngredientID(null));
            Assert.ThrowsException<NullReferenceException>(() => controller.GetIngredientByIngredientID(""));
            Assert.ThrowsException<NullReferenceException>(() => controller.GetIngredientByIngredientID("  "));
        }
    }
}
