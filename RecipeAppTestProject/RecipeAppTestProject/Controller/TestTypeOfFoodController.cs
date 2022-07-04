using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RecipeBookApp.Controller;
using RecipeBookApp.Model;
using System.Collections.Generic;

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
        /// Tests that GetFoodTypes(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetFoodTypesByRecipeIDThrowsExceptionIfZero()
        {
            List<FoodType> foods = controller.GetFoodTypes(0);
        }

        /// <summary>
        /// Tests that GetFoodTypes(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetFoodTypesByRecipeIDThrowsExceptionIfNegative()
        {
            List<FoodType> foods = controller.GetFoodTypes(-1);
        }
    }
}
