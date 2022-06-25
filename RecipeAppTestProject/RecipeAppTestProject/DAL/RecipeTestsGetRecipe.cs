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
       
        [TestMethod]
        public void TestGetRecipesMethod()
        {
            List<Recipe> recipetestList  = new List<Recipe>();
            RecipeDAL testRecipeDal = new RecipeDAL();
            recipetestList = testRecipeDal.GetRecipes();  
            
            Assert.AreEqual(5, recipetestList.Count);
        }

    
    }
}
