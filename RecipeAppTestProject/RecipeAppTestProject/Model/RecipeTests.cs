using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace RecipeAppTestProject.Model
{
    /// <summary>
    /// Test class to test the Recipe Model class
    /// </summary>
    [TestClass]
    public class RecipeTests
    {
        /// <summary>
        /// Test Method to create get the Recipes 
        /// </summary>
        [TestMethod]
        public void TestGetRecipesMethod()
        {
            List<Recipe> RecipeList = new List<Recipe>();
            string workingDirectory = Environment.CurrentDirectory;
            string path = Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"Data\", "sampleimage.jpg");
            Recipe recipe = new Recipe
            {
                RecipeId = 1,
                RecipeName = "Garlic Bread",
                RecipeInstructions = "Some Test ",
                CookingTime = 1,
                NutritionId = 2,
                EthnicId = 3,
                RecipeImage = Image.FromFile(path)
            };
            Recipe recipe2 = new Recipe
            {
                RecipeId = 2,
                RecipeName = "Alfredo Bread",
                RecipeInstructions = "Some Test ",
                CookingTime = 3,
                NutritionId = 6,
                EthnicId = 4,
                RecipeImage = Image.FromFile(path)
            };

            RecipeList.Add(recipe);
            RecipeList.Add(recipe2);

            Assert.AreEqual(2, RecipeList.Count);
        }


        /// <summary>
        /// Test Method to create the Recipe
        /// </summary>
      
        [TestMethod]
        public void TestCreateRecipeMethod()
        {
            List<Recipe> RecipeList = new List<Recipe>();
            string workingDirectory = Environment.CurrentDirectory;
            string path = Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"Data\", "sampleimage.jpg");
            Recipe recipe = new Recipe
            {
                RecipeId = 1,
                RecipeName = "Garlic Bread",
                RecipeInstructions = "Some Test ",
                CookingTime = 1,
                NutritionId = 2,
                EthnicId = 3,
                RecipeImage = Image.FromFile(path)
            };
            Recipe recipe2 = new Recipe
            {
                RecipeId = 2,
                RecipeName = "Alfredo Bread",
                RecipeInstructions = "Some Test ",
                CookingTime = 3,
                NutritionId = 6,
                EthnicId = 4,
                RecipeImage = Image.FromFile(path)
            };

            RecipeList.Add(recipe);
            RecipeList.Add(recipe2);
            Assert.AreEqual("Garlic Bread", RecipeList[0].RecipeName);
            Assert.AreEqual(4, RecipeList[1].EthnicId);
        }


        /// <summary>
        /// Test Method to delete the Recipe
        /// </summary>

        [TestMethod]
        public void TestDeleteRecipeMethod()
        {
            List<Recipe> RecipeList = new List<Recipe>();
            string workingDirectory = Environment.CurrentDirectory;
            string path = Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"Data\", "sampleimage.jpg");
            Recipe recipe = new Recipe
            {
                RecipeId = 1,
                RecipeName = "Garlic Bread",
                RecipeInstructions = "Some Test ",
                CookingTime = 1,
                NutritionId = 2,
                EthnicId = 3,
                RecipeImage = Image.FromFile(path)
            };
            Recipe recipe2 = new Recipe
            {
                RecipeId = 2,
                RecipeName = "Alfredo Bread",
                RecipeInstructions = "Some Test ",
                CookingTime = 3,
                NutritionId = 6,
                EthnicId = 4,
                RecipeImage = Image.FromFile(path)
            };

            RecipeList.Add(recipe);
            RecipeList.Add(recipe2);
            RecipeList.RemoveAll(x => x.RecipeId == 1);

            Assert.AreEqual("Alfredo Bread", RecipeList[0].RecipeName);
      
        }

        /// <summary>
        /// Test Method to update the Recipe
        /// </summary>

        [TestMethod]
        public void TestUpdateRecipeMethod()
        {
            List<Recipe> RecipeList = new List<Recipe>();
            string workingDirectory = Environment.CurrentDirectory;
            string path = Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"Data\", "sampleimage.jpg");
            Recipe recipe = new Recipe
            {
                RecipeId = 1,
                RecipeName = "Garlic Bread",
                RecipeInstructions = "Some Test ",
                CookingTime = 1,
                NutritionId = 2,
                EthnicId = 3,
                RecipeImage = Image.FromFile(path)
            };
            Recipe recipe2 = new Recipe
            {
                RecipeId = 2,
                RecipeName = "Alfredo Bread",
                RecipeInstructions = "Some Test ",
                CookingTime = 3,
                NutritionId = 6,
                EthnicId = 4,
                RecipeImage = Image.FromFile(path)
            };

            RecipeList.Add(recipe);
            RecipeList.Add(recipe2);
            foreach (Recipe updateRecipe in RecipeList)
            {
                if (updateRecipe.RecipeId==2)
                {
                    updateRecipe.NutritionId = 8;
                }
               else if (updateRecipe.RecipeId == 1)
                {
                    updateRecipe.RecipeName = "Tomato Soup";
                }
            }
        
            Assert.AreEqual("Tomato Soup", RecipeList[0].RecipeName);
            Assert.AreEqual(8, RecipeList[1].NutritionId);
        }

        /// <summary>
        /// Test that recipe can be instantiated even if image is null
        /// </summary>
        [TestMethod]
        public void TestRecipeImageCanBeNull()
        {
            Recipe recipe = new Recipe
            {
                RecipeId = 1,
                RecipeName = "lol",
                RecipeInstructions = "lol",
                CookingTime = 1,
                NutritionId = 1,
                EthnicId = 1,

                RecipeImage = null,
                UserWhoCreated = "greg"
            };
            Assert.AreNotEqual(recipe, null);
        }
    }
}
