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
    }
}
