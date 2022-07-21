using System;
using System.Collections.Generic;
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
        Recipe recipe;
        Nutrition nutrition;
        User admin;
        List<Ingredient> ingredients;
        List<MealType> mealTypes;
        List<Kitchenware> kitchenware;

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
            admin = new User
            {
                ID = 6,
                Name = "joe",
                Is_Admin = true
            };
            recipe = new Recipe();
            nutrition = new Nutrition();

            ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient
            {
                IngredientId = 1001,
                IngredientName = "ingredient",
                FoodId = 1001,
                Amount = "1"
            });

            mealTypes = new List<MealType>();
            mealTypes.Add(new MealType
            {
                mealTypeID = 1001,
                type = "type"
            });

            kitchenware = new List<Kitchenware>();
            kitchenware.Add(new Kitchenware
            {
                KitchenwareId = 1001,
                KitchenwareDetails = "details"
            });
        }

        /// <summary>
        /// Tests that GetRecipe(int) throws errors if int is less than 1
        /// </summary>
        [TestMethod]
        public void TestGetRecipeByRecipeIDThrowsExceptionIfLessThanOne()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetRecipe(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.GetRecipe(-1));
        }

        /// <summary>
        /// Tests that GetRecipeSearch(string) throws error if string is null or empty
        /// </summary>
        [TestMethod]
        public void TestGetRecipeSearchThrowsExceptionIfNullOrEmpty()
        {
            Assert.ThrowsException<ArgumentNullException>(() => controller.GetRecipeSearch(null));
            Assert.ThrowsException<ArgumentNullException>(() => controller.GetRecipeSearch(""));
            Assert.ThrowsException<ArgumentNullException>(() => controller.GetRecipeSearch("  "));
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
        /// Tests that AddRecipe throws error if pass null parameters, empty lists, or
        /// Recipe and Nutrition IDs that are preset (greater than 0)
        /// </summary>
        [TestMethod]
        public void TestAddRecipeThrowsExceptionIfParametersAreNullOrListsAreEmptyOrIDsArePreset()
        {
            List<Ingredient> ingredients_empty = new List<Ingredient>();
            List<MealType> mealTypes_empty = new List<MealType>();
            List<Kitchenware> kitchenware_empty = new List<Kitchenware>();

            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(null, recipe, ingredients,
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

            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(joe, recipe, ingredients_empty,
                mealTypes, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(joe, recipe, ingredients,
                mealTypes_empty, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware_empty, nutrition));

            nutrition = new Nutrition
            {
                NutritionId = 1,
                Carbohydrate = 1,
                Protein = 1,
                Fat = 1,
                Calories = 1,
                Alcohol = 1,
                ServingSize = "1"
            };
            recipe = new Recipe
            {
                RecipeId = 1,
                NutritionId = 1,
                UserWhoCreated = "greg",
                RecipeName = "recipe",
                RecipeInstructions = "instructions",
                RecipeImage = null,
                CookingTime = 1,
                EthnicId = 1
            };

            Assert.ThrowsException<ArgumentException>(() => controller.AddRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware, nutrition));
        }

        /// <summary>
        /// Tests that AddRecipe returns error with badly formed data
        /// </summary>
        [TestMethod]
        public void TestAddRecipeReturnsErrorWithBadlyFormedData()
        {
            Assert.ThrowsException<ArgumentNullException>(() => controller.AddRecipe(joe, 
                recipe, ingredients, mealTypes, kitchenware, nutrition));

            nutrition = new Nutrition
            {
                Carbohydrate = 1,
                Protein = 1,
                Fat = 1,
                Calories = 1,
                Alcohol = 1,
                ServingSize = "1"
            };
            recipe = new Recipe
            {

            };
            Assert.ThrowsException<NullReferenceException>(() => controller.AddRecipe(joe,
                recipe, ingredients, mealTypes, kitchenware, nutrition));
        }

        /// <summary>
        /// Tests that DeleteRecipe throws exception when bad user or recipe data is passed
        /// </summary>
        [TestMethod]
        public void TestDeleteRecipeThrowsExceptionWithBadUserOrRecipe()
        {
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.DeleteRecipe(null, recipe));
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.DeleteRecipe(joe, null));
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.DeleteRecipe(joe, recipe));

            recipe = new Recipe
            {
                RecipeId = -1,
                UserWhoCreated = "joe"
            };
            Assert.ThrowsException<ArgumentException>(() => controller.DeleteRecipe(joe, recipe));
            Assert.ThrowsException<ArgumentException>(() => controller.DeleteRecipe(admin, recipe));
        }

        /// <summary>
        /// Update Amount of Ingredient throws the expected exceptions
        /// </summary>
        [TestMethod]
        public void TestUpdateAmountOfIngredientThrowsExpectedExceptions()
        {
            Ingredient ingredient = new Ingredient
            {

            };

            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateAmountOfIngredient(null, recipe, ingredient));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateAmountOfIngredient(joe, null, ingredient));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateAmountOfIngredient(joe, recipe, null));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateAmountOfIngredient(admin, null, ingredient));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateAmountOfIngredient(admin, recipe, null));

            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.UpdateAmountOfIngredient(joe, recipe, ingredient));

            recipe = new Recipe
            {
                UserWhoCreated = "greg"
            };
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.UpdateAmountOfIngredient(joe, recipe, ingredient));
        }

        /// <summary>
        /// Tests that UpdateRecipe returns error with badly formed data
        /// </summary>
        [TestMethod]
        public void TestUpdateAmountOfIngredientThrowsExceptionWithBadlyFormedData()
        {
            recipe = new Recipe
            {
                UserWhoCreated = "joe"
            };
            Ingredient ingredient = new Ingredient
            {

            };
            Assert.ThrowsException<NullReferenceException>(() => controller.UpdateAmountOfIngredient(joe,
                recipe, ingredient));
        }

        /// <summary>
        /// Tests that UpdateRecipe throws expected exceptions
        /// </summary>
        [TestMethod]
        public void TestUpdateRecipeThrowsExpectedExceptions()
        {
            List<Ingredient> ingredients_empty = new List<Ingredient>();
            List<MealType> mealTypes_empty = new List<MealType>();
            List<Kitchenware> kitchenware_empty = new List<Kitchenware>();

            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateRecipe(null, recipe, ingredients,
                mealTypes, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateRecipe(joe, null, ingredients,
                mealTypes, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateRecipe(joe, recipe, null,
                mealTypes, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateRecipe(joe, recipe, ingredients,
                null, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateRecipe(joe, recipe, ingredients,
                mealTypes, null, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware, null));

            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.UpdateRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware, nutrition));

            recipe = new Recipe
            {
                UserWhoCreated = "greg"
            };
            Assert.ThrowsException<UnauthorizedAccessException>(() => controller.UpdateRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware, nutrition));

            recipe = new Recipe
            {
                UserWhoCreated = "joe"
            };
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateRecipe(joe, recipe, ingredients_empty,
                mealTypes, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateRecipe(joe, recipe, ingredients,
                mealTypes_empty, kitchenware, nutrition));
            Assert.ThrowsException<ArgumentNullException>(() => controller.UpdateRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware_empty, nutrition));

            nutrition = new Nutrition
            {
                NutritionId = -1,
                Carbohydrate = 1,
                Protein = 1,
                Fat = 1,
                Calories = 1,
                Alcohol = 1,
                ServingSize = "1"
            };
            recipe = new Recipe
            {
                RecipeId = -1,
                NutritionId = 1,
                UserWhoCreated = "joe",
                RecipeName = "recipe",
                RecipeInstructions = "instructions",
                RecipeImage = null,
                CookingTime = 1,
                EthnicId = 1
            };

            Assert.ThrowsException<ArgumentException>(() => controller.UpdateRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware, nutrition));

            nutrition = new Nutrition
            {
                NutritionId = 1,
                Carbohydrate = 1,
                Protein = 1,
                Fat = 1,
                Calories = 1,
                Alcohol = 1,
                ServingSize = "1"
            };
            recipe = new Recipe
            {
                RecipeId = 1,
                NutritionId = 2,
                UserWhoCreated = "joe",
                RecipeName = "recipe",
                RecipeInstructions = "instructions",
                RecipeImage = null,
                CookingTime = 1,
                EthnicId = 1
            };

            Assert.ThrowsException<ArgumentException>(() => controller.UpdateRecipe(joe, recipe, ingredients,
                mealTypes, kitchenware, nutrition));
        }

        /// <summary>
        /// Tests that UpdateRecipe returns error with badly formed data
        /// </summary>
        [TestMethod]
        public void TestUpdateRecipeReturnsErrorWithBadlyFormedData()
        {
            recipe = new Recipe
            {
                RecipeId = 1,
                UserWhoCreated = "joe",
                NutritionId = 1
            };
            nutrition = new Nutrition
            {
                NutritionId = 1,
                Carbohydrate = 1,
                Protein = 1,
                Fat = 1,
                Calories = 1,
                Alcohol = 1,
                ServingSize = "1"
            };

            Assert.ThrowsException<NullReferenceException>(() => controller.UpdateRecipe(joe,
                recipe, ingredients, mealTypes, kitchenware, nutrition));
        }
    }
}
