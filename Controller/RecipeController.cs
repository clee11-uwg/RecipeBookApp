﻿using System;
using System.Collections.Generic;
using System.Transactions;
using System.IO;
using System.Linq;
using RecipeBookApp.DAL;
using RecipeBookApp.Model;

namespace RecipeBookApp.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the Recipe application
    /// and the RecipeDAL.
    /// </summary>
    public class RecipeController
    {
        private readonly RecipeDAL recipeDAL;
        private static string recipeInstructions;

        /// <summary>
        /// Instantiate instance variables
        /// </summary>
        public RecipeController()
        {
            this.recipeDAL = new RecipeDAL();
        }

        /// <summary>
        /// Gets all Recipe  Recipe table.
        /// </summary>
        /// <returns>List of all Recipes from database </returns>
        public  List<Recipe> GetRecipes()
        {
            return this.recipeDAL.GetRecipes();
        }

        /// <summary>
        /// Gets the recipe for the search ID.
        /// </summary>
        /// <param name="searchRecipeID">ID of the recipe</param>
        /// <returns>Recipe found in the database</returns>
        public  Recipe GetRecipe(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID cannot be less than 1");
            }
            return this.recipeDAL.GetRecipe(searchRecipeID);
        }

        /// <summary>
        /// Gets the recipes matching the search input.
        /// </summary>
        /// <param name="searchUserInput">Search stirng to find recipes by</param>
        /// <returns>Recipes found in the database</returns>
        public List<Recipe> GetRecipeSearch(string searchUserInput)
        {
            if (string.IsNullOrEmpty(searchUserInput))
            {
                throw new ArgumentNullException("Search string cannot be null or empty");
            }
            return this.recipeDAL.GetSearchRecipe(searchUserInput);
        }

        /// <summary>
        /// Returns list of filtered recipes
        /// </summary>
        /// <param name="allergens">Undesired allergens</param>
        /// <param name="ethnicities">Undesired ethnicities</param>
        /// <param name="foodTypes">Undesired types of food</param>
        /// <param name="ingredients">Undesired ingredients</param>
        /// <param name="kitchenware">Undesired kitchenware</param>
        /// <param name="mealTypes">Undesired types of meal</param>
        /// <param name="nutrition">Undesired nutrition</param>
        /// <returns>List of recipes</returns>
        public List<Recipe> FilterRecipes(int[] allergens, int[] ethnicities, int[] foodTypes,
            int[] ingredients, int[] kitchenware, int[] mealTypes, int[] nutrition)
        {
            if (allergens == null) allergens = new int[0];
            if (ethnicities == null || ethnicities.Length == 0) ethnicities = new int[1]{0};
            if (foodTypes == null || foodTypes.Length == 0) foodTypes = new int[1]{0};
            if (ingredients == null || ingredients.Length == 0) ingredients = new int[1]{0};
            if (kitchenware == null || kitchenware.Length == 0) kitchenware = new int[1]{0};
            if (mealTypes == null || mealTypes.Length == 0) mealTypes = new int[1]{0};
            if (nutrition == null) nutrition = new int[0];
            return this.recipeDAL.FilterRecipes(allergens, ethnicities, foodTypes, ingredients, 
                kitchenware, mealTypes, nutrition);
        }

        /// <summary>
        /// Returns a list of the user's favorite recipes
        /// </summary>
        /// <param name="userID">User ID of the user</param>
        /// <returns>List of favorite recipes</returns>
        public List<Recipe> GetFavoriteRecipes(int userID)
        {
            if (userID < 1)
            {
                throw new ArgumentOutOfRangeException("User ID cannot be less than 1");
            }
            return this.recipeDAL.GetFavoriteRecipes(userID);
        }


        /// <summary>
        /// Inserts the recipe into the database
        /// </summary>
        /// <param name="user">User who is calling</param>
        /// <param name="recipe">Recipe to add</param>
        /// <param name="ingredients">Ingredients of the recipe</param>
        /// <param name="mealTypes">Types of Meal for the Recipe</param>
        /// <param name="kitchenware">Kitchenware used by the recipe</param>
        /// <param name="nutrition">Nutrition of the recipe</param>
        /// <returns>Whether or not the recipe was inserted</returns>
        public bool AddRecipe(User user, Recipe recipe, List<Ingredient> ingredients, List<MealType> mealTypes,
                List<Kitchenware> kitchenware, Nutrition nutrition)
        {
            if (user == null || recipe == null || ingredients == null || 
                    mealTypes == null || kitchenware == null || nutrition == null)
            {
                throw new ArgumentNullException("Parameters cannot be null");
            }
            if (!ingredients.Any() || !mealTypes.Any() || !kitchenware.Any())
            {
                throw new ArgumentException("Ingredients, Meal Types, and Kitchenware cannot be empty");
            }
            if (recipe.RecipeId > 0 || recipe.NutritionId > 0 || nutrition.NutritionId > 0)
            {
                throw new ArgumentException("AddRecipe is not an UPDATE query. RecipeID and NutritionID should be set to 0 or negative");
            }

            using (TransactionScope scope = new TransactionScope())
            {
                NutritionDAL nutritionDAL = new NutritionDAL();
                recipe.NutritionId = nutritionDAL.AddNutrition(nutrition);

                recipe.RecipeId = this.recipeDAL.AddRecipe(recipe);
                this.recipeDAL.AddImage(recipe);

                foreach (Ingredient ingredient in ingredients)
                {
                    this.recipeDAL.AddRecipeHasIngredient(recipe.RecipeId, ingredient.IngredientId, ingredient.Amount);
                }
                foreach (MealType mealType in mealTypes)
                {
                    this.recipeDAL.AddRecipeIsATypeOfMeal(recipe.RecipeId, mealType.mealTypeID);
                }
                foreach (Kitchenware pots in kitchenware)
                {
                    this.recipeDAL.AddRecipeUsesKitchenware(recipe.RecipeId, pots.KitchenwareId);
                }

                scope.Complete();
            }
            return true;
        }

        /// <summary>
        /// Deletes the recipe from the database
        /// </summary>
        /// <param name="user">User who is calling</param>
        /// <param name="recipe">Recipe to delete</param>
        /// <returns>Whether or not the recipe was deleted</returns>
        public bool DeleteRecipe(User user, Recipe recipe)
        {
            if (user == null || recipe == null)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }
            if (user.Is_Admin == false && user.Name != recipe.UserWhoCreated)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }
            if (recipe.RecipeId < 1)
            {
                throw new ArgumentException("RecipeID must be valid");
            }

            using (TransactionScope scope = new TransactionScope())
            {
                NutritionDAL nutritionDAL = new NutritionDAL();
                nutritionDAL.DeleteNutrition(recipe.NutritionId);

                this.recipeDAL.DeleteImage(recipe.RecipeId);
                this.recipeDAL.DeleteRecipeHasIngredient(recipe.RecipeId);
                this.recipeDAL.DeleteRecipeIsATypeOfMeal(recipe.RecipeId);
                this.recipeDAL.DeleteRecipeUsesKitchenware(recipe.RecipeId);

                recipe.RecipeId = this.recipeDAL.AddRecipe(recipe);
                scope.Complete();
            }
            return true;
        }

        /// <summary>
        /// Updates the recipe into the database
        /// </summary>
        /// <param name="user">User who is calling</param>
        /// <param name="recipe">Recipe to update</param>
        /// <param name="ingredients">Ingredients of the recipe</param>
        /// <returns>Whether or not the recipe was updated</returns>
        public bool UpdateAmountOfIngredient(User user, Recipe recipe, Ingredient ingredient)
        {
            if (user == null || recipe == null || ingredient == null)
            {
                throw new ArgumentNullException("Parameters cannot be null");
            }
            if (user.Is_Admin == false && user.Name != recipe.UserWhoCreated)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }

            return this.recipeDAL.UpdateAmountInRecipeHasIngredient(recipe.RecipeId, ingredient.IngredientId, ingredient.Amount);
        }

        /// <summary>
        /// Updates the recipe into the database
        /// </summary>
        /// <param name="user">User who is calling</param>
        /// <param name="recipe">Recipe to update</param>
        /// <param name="ingredients">Ingredients of the recipe</param>
        /// <param name="mealTypes">Types of Meal for the Recipe</param>
        /// <param name="kitchenware">Kitchenware used by the recipe</param>
        /// <param name="nutrition">Nutrition of the recipe</param>
        /// <returns>Whether or not the recipe was updated</returns>
        public bool UpdateRecipe(User user, Recipe recipe, List<Ingredient> ingredients, List<MealType> mealTypes,
                List<Kitchenware> kitchenware, Nutrition nutrition)
        {
            if (user == null || recipe == null || ingredients == null || 
                    mealTypes == null || kitchenware == null || nutrition == null)
            {
                throw new ArgumentNullException("Parameters cannot be null");
            }
            if (user.Is_Admin == false && user.Name != recipe.UserWhoCreated)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }
            if (!ingredients.Any() || !mealTypes.Any() || !kitchenware.Any())
            {
                throw new ArgumentException("Ingredients, Meal Types, and Kitchenware cannot be empty");
            }
            if (recipe.RecipeId < 1 || recipe.NutritionId < 1 || nutrition.NutritionId < 1)
            {
                throw new ArgumentException("RecipeID and NutritionID must be greater than zero");
            }
            if (recipe.NutritionId != nutrition.NutritionId)
            {
                throw new ArgumentException("Recipe and Nutrition must have same nutritionID");
            }

            //using (TransactionScope scope = new TransactionScope())
            //{
                NutritionDAL nutritionDAL = new NutritionDAL();
                nutritionDAL.UpdateNutrition(nutrition);

                this.recipeDAL.UpdateRecipe(recipe);
                this.recipeDAL.UpdateImage(recipe);

                this.recipeDAL.DeleteRecipeHasIngredient(recipe.RecipeId);
                this.recipeDAL.DeleteRecipeIsATypeOfMeal(recipe.RecipeId);
                this.recipeDAL.DeleteRecipeUsesKitchenware(recipe.RecipeId);

                foreach (Ingredient ingredient in ingredients)
                {
                    this.recipeDAL.AddRecipeHasIngredient(recipe.RecipeId, ingredient.IngredientId, ingredient.Amount);
                }
                foreach (MealType mealType in mealTypes)
                {
                    this.recipeDAL.AddRecipeIsATypeOfMeal(recipe.RecipeId, mealType.mealTypeID);
                }
                foreach (Kitchenware pots in kitchenware)
                {
                    this.recipeDAL.AddRecipeUsesKitchenware(recipe.RecipeId, pots.KitchenwareId);
                }

                //scope.Complete();
            //}
            return true;
        }
        public static void SetRecipeInstructions(string text)
        {
            recipeInstructions = text;
        }

        public static string GetRecipeInstructions()
        {
            return recipeInstructions ;
        }
    }
}
