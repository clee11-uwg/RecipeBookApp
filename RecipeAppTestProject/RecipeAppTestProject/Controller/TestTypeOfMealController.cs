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
        /// Tests GetMealTypes
        /// </summary>
        [TestMethod]
        public void TestGetMealTypes()
        {
            /**
            TypeOfMealController controller = new TypeOfMealController();
            List<MealType> meals = controller.GetMealTypes();
            List<MealType> expected = new List<MealType>();
            */
        }

        /// <summary>
        /// Tests that GetMealTypes(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetMealTypesByRecipeIDThrowsExceptionIfZero()
        {
            List<MealType> meals = controller.GetMealTypes(0);
        }

        /// <summary>
        /// Tests that GetMealTypes(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetMealTypesByRecipeIDThrowsExceptionIfNegative()
        {
            List<MealType> meals = controller.GetMealTypes(-1);
        }
    }
}
