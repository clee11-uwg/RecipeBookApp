using System;
using System.Collections.Generic;
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
        /// Tests that GetEthnicOrigin(int) throws errors if int is less than 1
        /// </summary>
        [TestMethod]
        public void TestGetEthnicitiesByRecipeIDThrowsExceptionIfLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetEthnicOrigin(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetEthnicOrigin(-1));
        }
    }
}
