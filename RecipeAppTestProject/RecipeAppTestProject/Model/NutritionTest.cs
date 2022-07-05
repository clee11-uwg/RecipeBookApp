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
        ///         

        [TestMethod]
        public void TestGetNutritionsMethod()
        {
            List<Nutrition> NutritionList = new List<Nutrition>();
            Nutrition Nutrition = new Nutrition
            {
                NutritionId = 1,
                Carbohydrate = 86,
                Protein = 7,
                Fat = 40,
                Alcohol = 0,
                Calories = 722,
                ServingSize = "1 Slice"
            };
            Nutrition Nutrition2 = new Nutrition
            {
                NutritionId = 2,    
                 Carbohydrate = 18,
                Protein = 4,
                Fat = 1,
                Alcohol = 0,
                Calories = 88,
                ServingSize = "1/4 pound"
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
                NutritionId = 1,
                Carbohydrate = 86,
                Protein = 7,
                Fat = 40,
                Alcohol = 0,
                Calories = 722,
                ServingSize = "1 Slice"
            };
            Nutrition Nutrition2 = new Nutrition
            {
                NutritionId = 2,
                Carbohydrate = 18,
                Protein = 4,
                Fat = 1,
                Alcohol = 0,
                Calories = 88,
                ServingSize = "1/4 pound"
            };


            NutritionList.Add(Nutrition);
            NutritionList.Add(Nutrition2);
            Assert.AreEqual("1 Slice", NutritionList[0].ServingSize);
        }


        /// <summary>
        /// Test Method to delete the Nutrition
        /// </summary>

        [TestMethod]
        public void TestDeleteNutritionMethod()
        {
            List<Nutrition> nutritionList = new List<Nutrition>();
            Nutrition Nutrition = new Nutrition
            {
                NutritionId = 1,
                Carbohydrate = 86,
                Protein = 7,
                Fat = 40,
                Alcohol = 0,
                Calories = 722,
                ServingSize = "1 Slice"
            };
            Nutrition Nutrition2 = new Nutrition
            {
                NutritionId = 2,
                Carbohydrate = 18,
                Protein = 4,
                Fat = 1,
                Alcohol = 0,
                Calories = 88,
                ServingSize = "1/4 pound"
            };

           
            nutritionList.Add(Nutrition);
            nutritionList.Add(Nutrition2);
            nutritionList.RemoveAll(x => x.NutritionId == 1);
            Assert.AreEqual(18, nutritionList[0].Carbohydrate);
            Assert.AreEqual(1, nutritionList.Count);

        }

        /// <summary>
        /// Test Method to update the Nutrition
        /// </summary>

        [TestMethod]
        public void TestUpdateNutritionMethod()
        {
            List<Nutrition> nutritionList = new List<Nutrition>();
            Nutrition nutrition = new Nutrition
            {
                NutritionId = 1,
                Carbohydrate = 86,
                Protein = 7,
                Fat = 40,
                Alcohol = 0,
                Calories = 722,
                ServingSize = "1 Slice"
            };
            Nutrition nutrition2 = new Nutrition
            {
                NutritionId = 2,
                Carbohydrate = 18,
                Protein = 4,
                Fat = 1,
                Alcohol = 0,
                Calories = 88,
                ServingSize = "1/4 pound"
            };

            nutritionList.Add(nutrition);
            nutritionList.Add(nutrition2);
            foreach (Nutrition updateNutrition in nutritionList)
            {
                if (updateNutrition.NutritionId == 2)
                {
                    updateNutrition.Protein = 10;
                }
            }
            Assert.AreEqual(10, nutritionList[1].Protein);

        }
    }
}
