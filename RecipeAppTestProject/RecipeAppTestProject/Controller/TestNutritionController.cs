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
        /// Tests that GetNutrition(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetNutritionByRecipeIDThrowsExceptionIfZero()
        {
            List<Nutrition> nutritions = controller.GetNutrition(0);
        }

        /// <summary>
        /// Tests that GetNutrition(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetNutritionByRecipeIDThrowsExceptionIfNegative()
        {
            List<Nutrition> nutritions = controller.GetNutrition(-1);
        }
    }
}
