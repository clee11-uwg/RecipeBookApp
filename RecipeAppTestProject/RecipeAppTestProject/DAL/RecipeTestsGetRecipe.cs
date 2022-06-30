using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace RecipeAppTestProject
{
    [TestClass]
    public class RecipeTestsGetRecipetestRecipesList
    {
        //  private const string Expected = "Hello World!";
        private List<Recipe> RecipetestList = null;

        [TestMethod]
        public void TestGetRecipesMethod()
        {
            RecipetestList = new List<Recipe>();
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

            RecipetestList.Add(recipe);
            RecipetestList.Add(recipe2);

            Assert.AreEqual(2, RecipetestList.Count);
        }


        [TestMethod]
        public void TestGetRecipesMethod2()
        {




        }
    }
}
