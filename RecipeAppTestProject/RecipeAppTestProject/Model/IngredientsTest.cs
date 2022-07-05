using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;

namespace RecipeAppTestProject.Model
{
    [TestClass]
    public class IngredientsTest
    {

        /// <summary>
        /// Test Method to  get the Recipes Ingredient
        /// </summary>
        [TestMethod]
        public void TestGetIngredientMethod()
        {
            List<Ingredient> recipeIngredientList = new List<Ingredient>();
            Ingredient newIngredient = new Ingredient
            {
                IngredientId = 1,
                IngredientName = "Soybeans",
                FoodId=4
            };
            Ingredient newIngredient2 = new Ingredient
            {
                IngredientId = 2,
                IngredientName = "Salt",
                FoodId = 9
            };

            recipeIngredientList.Add(newIngredient);
            recipeIngredientList.Add(newIngredient2);
            Assert.AreEqual(2, recipeIngredientList.Count);
        }


        /// <summary>
        /// Test Method to create the Recipe Ingredients
        /// </summary>

        [TestMethod]
        public void TestCreateRecipeIngredientsMethod()
        {
            List<Ingredient> recipeIngredientList = new List<Ingredient>();
            Ingredient newIngredient = new Ingredient
            {
                IngredientId = 1,
                IngredientName = "Soybeans",
                FoodId = 4
            };
            Ingredient newIngredient2 = new Ingredient
            {
                IngredientId = 2,
                IngredientName = "Salt",
                FoodId = 9
            };

            recipeIngredientList.Add(newIngredient);
            recipeIngredientList.Add(newIngredient2);
            Assert.AreEqual("Soybeans", recipeIngredientList[0].IngredientName);
        }


        /// <summary>
        /// Test Method to delete the Recipe Ingredients
        /// </summary>

        [TestMethod]
        public void TestDeleteRecipeIngredientsMethod()
        {
            List<Ingredient> recipeIngredientList = new List<Ingredient>();
            Ingredient newIngredient = new Ingredient
            {
                IngredientId = 1,
                IngredientName = "Soybeans",
                FoodId = 4
            };
            Ingredient newIngredient2 = new Ingredient
            {
                IngredientId = 2,
                IngredientName = "Salt",
                FoodId = 9
            };

            recipeIngredientList.Add(newIngredient);
            recipeIngredientList.Add(newIngredient2);
            Assert.AreEqual(2, recipeIngredientList.Count);
            recipeIngredientList.RemoveAll(x => x.IngredientId == 1);
            Assert.AreEqual("Salt", recipeIngredientList[0].IngredientName);
            Assert.AreEqual(1, recipeIngredientList.Count);

        }

        /// <summary>
        /// Test Method to update the Recipe Ingredients
        /// </summary>

        [TestMethod]
        public void TestUpdateRecipeIngredientsMethod()
        {
            List<Ingredient> recipeIngredientList = new List<Ingredient>();
            Ingredient newIngredient = new Ingredient
            {
                IngredientId = 1,
                IngredientName = "Soybeans",
                FoodId = 4
            };
            Ingredient newIngredient2 = new Ingredient
            {
                IngredientId = 2,
                IngredientName = "Salt",
                FoodId = 9
            };

            recipeIngredientList.Add(newIngredient);
            recipeIngredientList.Add(newIngredient2);
            foreach (Ingredient updateIngredient in recipeIngredientList)
            {
                if (updateIngredient.IngredientId == 2)
                {
                    updateIngredient.IngredientName = "Black beans";
                }
            }

            Assert.AreEqual("Black beans", recipeIngredientList[1].IngredientName);
        }
   
    }
}
