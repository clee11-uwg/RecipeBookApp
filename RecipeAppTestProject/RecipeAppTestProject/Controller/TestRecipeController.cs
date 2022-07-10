using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Controller;
using RecipeBookApp.Model;

namespace RecipeAppTestProject.Controller
{
    /// <summary>
    /// Class containing test methods for Type of Meal Controller
    /// </summary>
    [TestClass]
    public class TestRecipeController
    {
        RecipeController controller;
        User joe;

        /// <summary>
        /// Initialize RecipeController used in tests
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            controller = new RecipeController();
            joe = new User
            {
                ID = 6,
                Name = "joe",
                Is_Admin = false
            };
        }

        /// <summary>
        /// Tests that GetRecipe(int) throws errors if int is 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetRecipeByRecipeIDThrowsExceptionIfZero()
        {
            Recipe recipe = controller.GetRecipe(0);
        }

        /// <summary>
        /// Tests that GetRecipe(int) throws errors if int is negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetRecipeByRecipeIDThrowsExceptionIfNegative()
        {
            Recipe recipe = controller.GetRecipe(-1);
        }

        /// <summary>
        /// Tests that GetRecipeSearch(string) throws error if string is null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetRecipeSearchThrowsExceptionIfNull()
        {
            List<Recipe> recipes = controller.GetRecipeSearch(null);
        }

        /// <summary>
        /// Tests that GetRecipeSearch(string) throws error if string is empty
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetRecipeSearchThrowsExceptionIfEmpty()
        {
            List<Recipe> recipes = controller.GetRecipeSearch("");
        }

        /// <summary>
        /// Tests that GetFavoriteRecipes(int) throws exception if int is less than 1
        /// </summary>
        [TestMethod]
        public void TestGetFavoriteRecipeThrowsExceptionIfUserIDIsLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetFavoriteRecipes(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetFavoriteRecipes(-1));
        }

        /// <summary>
        /// Tests that AddRecipe throws error if pass null parameters or empty lists
        /// </summary>
        [TestMethod]
        public void TestAddRecipeThrowsExceptionIfParametersAreNullOrListsAreEmpty()
        {
            Recipe recipe = new Recipe();
            Nutrition nutrition = new Nutrition();
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient
            {
                IngredientId = 1001,
                IngredientName = "ingredient",
                FoodId = 1001,
                Amount = "1"
            });
            List<MealType> mealTypes = new List<MealType>();
            mealTypes.Add(new MealType
            {
                mealTypeID = 1001,
                type = "type"
            });
            List<Kitchenware> kitchenware = new List<Kitchenware>();
            kitchenware.Add(new Kitchenware
            {
                KitchenwareId = 1001,
                KitchenwareDetails = "details"
            });

            List<Ingredient> ingredients_empty = new List<Ingredient>();
            List<MealType> mealTypes_empty = new List<MealType>();
            List<Kitchenware> kitchenware_empty = new List<Kitchenware>();

            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(null, null, ingredients,
                mealTypes, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(joe, null, ingredients, 
                mealTypes, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(joe, recipe, null,
                mealTypes, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(joe, recipe, ingredients,
                null, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(joe, recipe, ingredients,
                mealTypes, null, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware, null));

            Assert.ThrowsException<ArgumentException>(() => controller.AddRecipe(joe, recipe, ingredients_empty,
                mealTypes, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentException>(() => controller.AddRecipe(joe, recipe, ingredients,
                mealTypes_empty, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentException>(() => controller.AddRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware_empty, nutrition));
        }
    }
}
