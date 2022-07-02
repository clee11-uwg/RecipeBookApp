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
        /// Tests that GetAllergen(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetAllergenByRecipeIDThrowsExceptionIfZero()
        {
            List<Allergen> allergens = controller.GetAllergen(0);
        }

        /// <summary>
        /// Tests that GetAllergen(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetAllergenByRecipeIDThrowsExceptionIfNegative()
        {
            List<Allergen> allergens = controller.GetAllergen(-1);
        }

        /// <summary>
        /// Tests that GetAllergensOfIngredient(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetAllergensOfIngredientByRecipeIDThrowsExceptionIfZero()
        {
            List<Allergen> allergens = controller.getAllergensOfIngredient(0);
        }

        /// <summary>
        /// Tests that GetAllergensOfIngredient(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetAllergensOfIngredientByRecipeIDThrowsExceptionIfNegative()
        {
            List<Allergen> allergens = controller.getAllergensOfIngredient(-1);
        }
    }
}
