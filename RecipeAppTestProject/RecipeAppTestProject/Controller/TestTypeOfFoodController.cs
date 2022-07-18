using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RecipeBookApp.Controller;

namespace RecipeAppTestProject.Controller
{
    /// <summary>
    /// Class containing test methods for Type of Food Controller
    /// </summary>
    [TestClass]
    public class TestTypeOfFoodController
    {
        TypeOfFoodController controller;

        /// <summary>
        /// Initialize TypeOfFoodController used in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new TypeOfFoodController();
        }

        /// <summary>
        /// Tests that GetFoodTypes(int) throws errors if int is less than one
        /// </summary>
        [TestMethod]
        public void TestGetFoodTypesByRecipeIDThrowsExceptionIfLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetFoodTypes(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetFoodTypes(-1));
        }
    }
}
