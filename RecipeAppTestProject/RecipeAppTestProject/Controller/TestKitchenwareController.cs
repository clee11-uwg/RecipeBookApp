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
        /// Tests that GetKitchenware(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetKitchenwareByRecipeIDThrowsExceptionIfZero()
        {
            List<Kitchenware> kitchenware = controller.GetKitchenware(0);
        }

        /// <summary>
        /// Tests that GetKitchenware(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetKitchenwareByRecipeIDThrowsExceptionIfNegative()
        {
            List<Kitchenware> kitchenware = controller.GetKitchenware(-1);
        }
    }
}
