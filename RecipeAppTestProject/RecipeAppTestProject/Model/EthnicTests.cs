using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Model;
using System.Collections.Generic;


namespace RecipeAppTestProject.Model
{
    /// <summary>
    /// Test class to test the Ethnicity Model class
    /// </summary>
    [TestClass]
    public class EthnicTests
    {
        /// <summary>
        /// Test Method to create get the Recipes Ethnicity 
        /// </summary>
        [TestMethod]
        public void TestGetEthnicityMethod()
        {
            List<Ethnic> ethnicityList = new List<Ethnic>();
            Ethnic recipeEthnicity = new Ethnic
            {
                EthnicId = 1,
                Ethnicity = "North American"
            };
            Ethnic recipeEthnicity2 = new Ethnic
            {
                EthnicId = 2,
                Ethnicity = "Northeast Asian"
            };
            ethnicityList.Add(recipeEthnicity);
            ethnicityList.Add(recipeEthnicity2);

            Assert.AreEqual(2, ethnicityList.Count);
        }


        /// <summary>
        /// Test Method to create the Recipe Ethnicity
        /// </summary>

        [TestMethod]
        public void TestCreateEthnicityMethod()
        {
            List<Ethnic> ethnicityList = new List<Ethnic>();
            Ethnic recipeEthnicity = new Ethnic
            {
                EthnicId = 1,
                Ethnicity = "North American"
            };
            Ethnic recipeEthnicity2 = new Ethnic
            {
                EthnicId = 2,
                Ethnicity = "Northeast Asian"
            };
            ethnicityList.Add(recipeEthnicity);
            ethnicityList.Add(recipeEthnicity2);
            Assert.AreEqual("North American", ethnicityList[0].Ethnicity);
        }


        /// <summary>
        /// Test Method to delete the Ethnicity
        /// </summary>

        [TestMethod]
        public void TestDeleteEthnicityMethod()
        {
            List<Ethnic> ethnicityList = new List<Ethnic>();
            Ethnic recipeEthnicity = new Ethnic
            {
                EthnicId = 1,
                Ethnicity = "North American"
            };
            Ethnic recipeEthnicity2 = new Ethnic
            {
                EthnicId = 2,
                Ethnicity = "Northeast Asian"
            };
            ethnicityList.Add(recipeEthnicity);
            ethnicityList.Add(recipeEthnicity2);

            ethnicityList.RemoveAll(x => x.EthnicId == 1);
            Assert.AreEqual("Northeast Asian", ethnicityList[0].Ethnicity);
      
        }

        /// <summary>
        /// Test Method to update the Ethnicity
        /// </summary>

        [TestMethod]
        public void TestUpdateEthnicityMethod()
        {
            List<Ethnic> ethnicityList = new List<Ethnic>();
            Ethnic recipeEthnicity = new Ethnic
            {
                EthnicId = 1,
                Ethnicity = "North American"
            };
            Ethnic recipeEthnicity2 = new Ethnic
            {
                EthnicId = 2,
                Ethnicity = "Northeast Asian"
            };
            ethnicityList.Add(recipeEthnicity);
            ethnicityList.Add(recipeEthnicity2);
            foreach (Ethnic updateEthnic in ethnicityList)
            {
                if (updateEthnic.EthnicId == 1)
                {
                    updateEthnic.Ethnicity = "Pacifia";
                }
            }
            Assert.AreEqual("Pacifia", ethnicityList[0].Ethnicity);
        }
    }
}
