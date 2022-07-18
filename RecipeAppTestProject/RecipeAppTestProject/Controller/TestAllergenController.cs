using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Controller;

namespace RecipeAppTestProject.Controller
{
    /// <summary>
    /// Class containing test methods for Allergen Controller
    /// </summary>
    [TestClass]
    public class TestAllergenController
    {
        AllergenController controller;

        /// <summary>
        /// Initialize AllergenController used in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new AllergenController();
        }

        /// <summary>
        /// Tests that GetAllergen(int) throws errors if int is less than 1
        /// </summary>
        [TestMethod]
        public void TestGetAllergenByRecipeIDThrowsExceptionIfLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetAllergen(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetAllergen(-1));
        }

        /// <summary>
        /// Tests that GetAllergensOfIngredient(int) throws errors if int is less than 1
        /// </summary>
        [TestMethod]
        public void TestGetAllergensOfIngredientByRecipeIDThrowsExceptionIfLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.getAllergensOfIngredient(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.getAllergensOfIngredient(-1));
        }
    }
}
