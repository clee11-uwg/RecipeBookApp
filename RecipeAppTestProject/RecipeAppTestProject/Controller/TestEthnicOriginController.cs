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
    /// Class containing test methods for EthnicOrigin Controller
    /// </summary>
    [TestClass]
    public class TestEthnicOriginController
    {
        EthnicOriginController controller;

        /// <summary>
        /// Initialize EthnicOriginController used in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new EthnicOriginController();
        }

        /// <summary>
        /// Tests that GetEthnicOrigin(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetEthnicitiesByRecipeIDThrowsExceptionIfZero()
        {
            List<Ethnic> ingredients = controller.GetEthnicOrigin(0);
        }

        /// <summary>
        /// Tests that GetEthnicOrigin(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetEthnicitiesByRecipeIDThrowsExceptionIfNegative()
        {
            List<Ethnic> ingredients = controller.GetEthnicOrigin(-1);
        }
    }
}
