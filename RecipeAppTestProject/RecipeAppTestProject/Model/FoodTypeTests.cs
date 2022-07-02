using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Model;
using System.Collections.Generic;

namespace RecipeAppTestProject.Model
{
    /// <summary>
    /// Test class to test the Food Type Model class
    /// </summary>
    [TestClass]
    public class FoodTypeTests
    {
        /// <summary>
        /// Test Method to create get the Recipes  Food Type
        /// </summary>
        [TestMethod]
        public void TestGetFoodTypeMethod()
        {
            List<FoodType> foodList = new List<FoodType>();
            FoodType food = new FoodType
            {
                FoodId = 1,
                TypeOfFood = "",
            };
            FoodType food2 = new FoodType
            {
                FoodId = 1,
                TypeOfFood = "",
            };

            foodList.Add(food);
            foodList.Add(food2);
            Assert.AreEqual(2, foodList.Count);
        }


        /// <summary>
        /// Test Method to create the Recipe Food Type
        /// </summary>
      
        [TestMethod]
        public void TestCreateFoodTypeMethod()
        {
            List<FoodType> foodList = new List<FoodType>();
            FoodType food = new FoodType
            {
                FoodId = 1,
                TypeOfFood = "Grain",
            };
            FoodType food2 = new FoodType
            {
                FoodId = 1,
                TypeOfFood = "Vegetable",
            };

            foodList.Add(food);
            foodList.Add(food2);
            Assert.AreEqual("Grain", foodList[0].TypeOfFood);
        }


        /// <summary>
        /// Test Method to delete the Recipe Food Type
        /// </summary>

        [TestMethod]
        public void TestDeleteFoodTypeMethod()
        {
            List<FoodType> foodList = new List<FoodType>();
            FoodType food = new FoodType
            {
                FoodId = 1,
                TypeOfFood = "Grain",
            };
            FoodType food2 = new FoodType
            {
                FoodId = 1,
                TypeOfFood = "Vegetable",
            };

            foodList.Add(food);
            foodList.Add(food2);
            foodList.RemoveAt(0);
            Assert.AreEqual("Vegetable", foodList[0].TypeOfFood);
            Assert.AreEqual(1, foodList.Count);

        }

        /// <summary>
        /// Test Method to update the Recipe Food type
        /// </summary>

        [TestMethod]
        public void TestUpdateFoodTypeMethod()
        {
            List<FoodType> foodList = new List<FoodType>();
            FoodType food = new FoodType
            {
                FoodId = 1,
                TypeOfFood = "Condiment",
            };
            FoodType food2 = new FoodType
            {
                FoodId = 1,
                TypeOfFood = "Alcohol",
            };

            foodList.Add(food);
            foodList.Add(food2);
            food2.TypeOfFood = "Legume";
            Assert.AreEqual(2, foodList.Count);
            Assert.AreEqual("Legume", foodList[1].TypeOfFood);
        }
    }
}
