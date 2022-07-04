using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Model;
using System.Collections.Generic;

namespace RecipeAppTestProject.Model
{
    /// <summary>
    /// Test class to test the Nutrition Model class
    /// </summary>
    [TestClass]
    public class NutritionTest
    {
        /// <summary>
        /// Test Method to create get the Nutritions 
        /// </summary>
        [TestMethod]
        public void TestGetNutritionsMethod()
        {
            List<Nutrition> NutritionList = new List<Nutrition>();
             Nutrition Nutrition = new Nutrition
            {
                NutritionId = 1,
            };
            Nutrition Nutrition2 = new Nutrition
            {
                NutritionId = 2
            };

            NutritionList.Add(Nutrition);
            NutritionList.Add(Nutrition2);

            Assert.AreEqual(2, NutritionList.Count);
        }


        /// <summary>
        /// Test Method to create the Nutrition
        /// </summary>
      
        [TestMethod]
        public void TestCreateNutritionMethod()
        {
            List<Nutrition> NutritionList = new List<Nutrition>();
            Nutrition Nutrition = new Nutrition
            {
                NutritionId = 1
            };
            Nutrition Nutrition2 = new Nutrition
            {
                NutritionId = 2
            };

            NutritionList.Add(Nutrition);
            NutritionList.Add(Nutrition2);
        }


        /// <summary>
        /// Test Method to delete the Nutrition
        /// </summary>

        [TestMethod]
        public void TestDeleteNutritionMethod()
        {
            List<Nutrition> NutritionList = new List<Nutrition>();
            Nutrition Nutrition = new Nutrition
            {
                NutritionId = 1
            };
            Nutrition Nutrition2 = new Nutrition
            {
                NutritionId = 2
            };

            NutritionList.Add(Nutrition);
            NutritionList.Add(Nutrition2);

        }

        /// <summary>
        /// Test Method to update the Nutrition
        /// </summary>

        [TestMethod]
        public void TestUpdateNutritionMethod()
        {
            List<Nutrition> NutritionList = new List<Nutrition>();
            Nutrition Nutrition = new Nutrition
            {
                NutritionId = 1
            };
            Nutrition Nutrition2 = new Nutrition
            {
                NutritionId = 2
            };

            NutritionList.Add(Nutrition);
            NutritionList.Add(Nutrition2);
        }
    }
}
