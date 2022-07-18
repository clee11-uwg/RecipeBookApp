using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Controller;


namespace RecipeAppTestProject.Controller
{
    /// <summary>
    /// Class containing test methods for Nutrition Controller
    /// </summary>
    [TestClass]
    public class TestNutritionController
    {
        NutritionController controller;

        /// <summary>
        /// Initialize NutritionController used in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new NutritionController();
        }

        /// <summary>
        /// Tests that GetNutrition(int) throws errors if int is less than one
        /// </summary>
        [TestMethod]
        public void TestGetNutritionByRecipeIDThrowsExceptionIfLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetNutrition(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetNutrition(-1));
        }

        /// <summary>
        /// Tests that GetNutritions throws exception if the sort parameter is null or not a nutrition attribute
        /// </summary>
        [TestMethod]
        public void TestGetNutritionThrowsExceptionIfAttributeIsNullOrInvalid()
        {
            Assert.ThrowsException<ArgumentNullException>(() => controller.GetNutritions(null));
            Assert.ThrowsException<ArgumentNullException>(() => controller.GetNutritions(""));
            Assert.ThrowsException<ArgumentNullException>(() => controller.GetNutritions("  "));

            Assert.ThrowsException<ArgumentException>(() => controller.GetNutritions("fake"));
            Assert.ThrowsException<ArgumentException>(() => controller.GetNutritions("another fake"));
        }
    }
}
