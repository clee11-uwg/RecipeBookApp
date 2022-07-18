using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Controller;

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
        /// Tests that GetIngredients(int) throws errors if int is less than one
        /// </summary>
        [TestMethod]
        public void TestGetIngredientsByRecipeIDThrowsExceptionIfLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetIngredient(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetIngredient(-1));
        }

        /// <summary>
        /// Get Ingredient by Name throws exception if name is null or empty
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
