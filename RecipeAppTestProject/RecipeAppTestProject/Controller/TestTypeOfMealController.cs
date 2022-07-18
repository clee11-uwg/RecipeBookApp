using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Controller;
using RecipeBookApp.Model;

namespace RecipeAppTestProject.Controller
{
    /// <summary>
    /// Class containing test methods for Type of Meal Controller
    /// </summary>
    [TestClass]
    public class TestTypeOfMealController
    {
        TypeOfMealController controller;

        /// <summary>
        /// Initialize TypeOfMealController used in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new TypeOfMealController();
        }

        /// <summary>
        /// Tests that GetMealTypes(int) throws errors if int is less than one
        /// </summary>
        [TestMethod]
        public void TestGetMealTypesByRecipeIDThrowsExceptionIfLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetMealTypes(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetMealTypes(-1));
        }

        /// <summary>
        /// GetMealTypeByName(string) throws exception if string is null or empty
        /// </summary>
        [TestMethod]
        public void TestGetMealTypeByNameThrowsExceptionWithNullOrEmptyString()
        {
            Assert.ThrowsException<NullReferenceException>(() => controller.GetMealTypeByName(null));
            Assert.ThrowsException<NullReferenceException>(() => controller.GetMealTypeByName(""));
            Assert.ThrowsException<NullReferenceException>(() => controller.GetMealTypeByName("  "));
        }
    }
}
