using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Model;
using System.Collections.Generic;

namespace RecipeAppTestProject.Model
{
    [TestClass]
    public class MealTypeTest
    {
        /// <summary>
        /// Test Method to create get the MealTypes 
        /// </summary>
        [TestMethod]
        public void TestGetMealTypeMethod()
        {
            List<MealType> MealTypeList = new List<MealType>();
            MealType mealType = new MealType
            {
                mealTypeID = 1,
                type = "Lunch"
            };
            MealType mealType2 = new MealType
            {
                mealTypeID = 2,
                type = "BreakFast"

            };

            MealTypeList.Add(mealType);
            MealTypeList.Add(mealType);

            Assert.AreEqual(2, MealTypeList.Count);
        }


        /// <summary>
        /// Test Method to create the MealType
        /// </summary>

        [TestMethod]
        public void TestCreateMealTypeMethod()
        {
            List<MealType> MealTypeList = new List<MealType>();
            MealType mealType = new MealType
            {
                mealTypeID = 1,
                type = "Lunch"
            };
            MealType mealType2 = new MealType
            {
                mealTypeID = 2,
                type = "BreakFast"

            };

            MealTypeList.Add(mealType);
            MealTypeList.Add(mealType2);
            Assert.AreEqual("Lunch", MealTypeList[0].type);
            Assert.AreEqual("BreakFast", MealTypeList[1].type);
        }


        /// <summary>
        /// Test Method to delete the MealType
        /// </summary>

        [TestMethod]
        public void TestDeleteMealTypeMethod()
        {

            List<MealType> MealTypeList = new List<MealType>();
            MealType mealType = new MealType
            {
                mealTypeID = 1,
                type = "Lunch"
            };
            MealType mealType2 = new MealType
            {
                mealTypeID = 2,
                type = "BreakFast"

            };

            MealTypeList.Add(mealType);
            MealTypeList.Add(mealType2);

            MealTypeList.RemoveAll(x => x.mealTypeID == 1);
            Assert.AreEqual("BreakFast", MealTypeList[0].type);

        }

        /// <summary>
        /// Test Method to update the MealType
        /// </summary>

        [TestMethod]
        public void TestUpdateMealTypeMethod()
        {
            List<MealType> MealTypeList = new List<MealType>();
            MealType mealType = new MealType
            {
                mealTypeID = 1,
                type = "Lunch"
            };
            MealType mealType2 = new MealType
            {
                mealTypeID = 2,
                type = "BreakFast"

            };

            MealTypeList.Add(mealType);
            MealTypeList.Add(mealType2);
            foreach (MealType updateMeal in MealTypeList)
            {
                if (updateMeal.mealTypeID == 1)
                {
                    updateMeal.type = "Dinner";
                }
            }
            Assert.AreEqual("Dinner", MealTypeList[0].type);
        }
    }
}
