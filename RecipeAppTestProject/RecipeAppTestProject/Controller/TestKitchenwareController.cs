using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Controller;

namespace RecipeAppTestProject.Controller
{
    /// <summary>
    /// Class containing test methods for Kitchenware Controller
    /// </summary>
    [TestClass]
    public class TestKitchenwareController
    {
        KitchenwareController controller;

        /// <summary>
        /// Initialize KitchenwareController used in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new KitchenwareController();
        }

        /// <summary>
        /// Tests that GetKitchenware(int) throws errors if int is less than one
        /// </summary>
        [TestMethod]
        public void TestGetKitchenwareByRecipeIDThrowsExceptionIfLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetKitchenware(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetKitchenware(-1));
        }

        /// <summary>
        /// Tests that GetKitchenwareByName throws exception if string is null or empty
        /// </summary>
        [TestMethod]
        public void TestGetKitchenwareByNameThrowsExceptionIfNameIsNullOrEmpty()
        {
            Assert.ThrowsException<NullReferenceException>(() => controller.GetKitchenwareByName(null));
            Assert.ThrowsException<NullReferenceException>(() => controller.GetKitchenwareByName(""));
            Assert.ThrowsException<NullReferenceException>(() => controller.GetKitchenwareByName(" "));
        }
    }
}
