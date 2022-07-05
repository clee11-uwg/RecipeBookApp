using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Model;
using System.Collections.Generic;

namespace RecipeAppTestProject.Model
{
    /// <summary>
    /// Test class to test the Allergen Model class
    /// </summary>
    [TestClass]
    public class AllergenTests
    {
        /// <summary>
        /// Test Method to create get the Recipe Allergen 
        /// </summary>
        [TestMethod]
        public void TestGetRecipeAllergenMethod()
        {
            List<Allergen> allergenList = new List<Allergen>();
            Allergen recipeAllergen = new Allergen
            {
               AllergenId=1,
               AllergenDetails= "Buckwheat"
            };
            Allergen recipeAllergen2 = new Allergen
            {
                AllergenId = 1,
                AllergenDetails = "Mango"
            };

            allergenList.Add(recipeAllergen);
            allergenList.Add(recipeAllergen2);

            Assert.AreEqual(2, allergenList.Count);
        }


        /// <summary>
        /// Test Method to create the Recipe Allergen
        /// </summary>

        [TestMethod]
        public void TestCreateRecipeAllergenMethod()
        {
            List<Allergen> allergenList = new List<Allergen>();
            Allergen recipeAllergen = new Allergen
            {
                AllergenId = 1,
                AllergenDetails = "Hot Peppers"
            };
            Allergen recipeAllergen2 = new Allergen
            {
                AllergenId = 1,
                AllergenDetails = "Maize"
            };
            allergenList.Add(recipeAllergen);
            allergenList.Add(recipeAllergen2);
            Assert.AreEqual("Hot Peppers", allergenList[0].AllergenDetails);
        }


        /// <summary>
        /// Test Method to delete the Recipe Allergen
        /// </summary>

        [TestMethod]
        public void TestDeleteRecipeAllergenMethod()
        {
            List<Allergen> allergenList = new List<Allergen>();
            Allergen recipeAllergen = new Allergen
            {
                AllergenId = 1,
                AllergenDetails = "Hot Peppers"
            };
            Allergen recipeAllergen2 = new Allergen
            {
                AllergenId = 1,
                AllergenDetails = "Maize"
            };
            allergenList.Add(recipeAllergen);
            allergenList.Add(recipeAllergen2);
            allergenList.RemoveAt(0);
            Assert.AreEqual("Maize", allergenList[0].AllergenDetails);
      
        }

        /// <summary>
        /// Test Method to update the Recipe Allergen
        /// </summary>

        [TestMethod]
        public void TestUpdateRecipeAllergenMethod()
        {
            List<Allergen> allergenList = new List<Allergen>();
            Allergen recipeAllergen = new Allergen
            {
                AllergenId = 1,
                AllergenDetails = "Hot Peppers"
            };
            Allergen recipeAllergen2 = new Allergen
            {
                AllergenId = 1,
                AllergenDetails = "Maize"
            };
            allergenList.Add(recipeAllergen);
            allergenList.Add(recipeAllergen2);
            allergenList[0].AllergenDetails = "Sesame";
            Assert.AreEqual("Sesame", allergenList[0].AllergenDetails);
        }
    }
}
