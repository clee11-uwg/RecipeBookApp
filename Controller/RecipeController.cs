using System;
using System.Collections.Generic;
using System.Transactions;
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

        /// <see cref="RecipeDAL.GetRecipes"/>
        public  List<Recipe> GetRecipes()
        {
            return this.recipeDAL.GetRecipes();
        }

        /// <see cref="RecipeDAL.GetRecipe(int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If searchRecipeID is less than 1</exception>
        public  Recipe GetRecipe(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID cannot be less than 1");
            }
            return this.recipeDAL.GetRecipe(searchRecipeID);
        }

        /// <see cref="RecipeDAL.GetSearchRecipe(string)"/>
        /// <exception cref="ArgumentNullException">If search string is null or empty</exception>
        public List<Recipe> GetRecipeSearch(string searchUserInput)
        {
            if (string.IsNullOrWhiteSpace(searchUserInput))
            {
                throw new ArgumentNullException("Search string cannot be null or empty");
            }
            return this.recipeDAL.GetSearchRecipe(searchUserInput);
        }

        /// <see cref="RecipeDAL.FilterRecipes(int[], int[], int[], int[], int[], int[], int[])"/>
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

        /// <see cref="RecipeDAL.GetFavoriteRecipes(int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If userID is less than 1</exception>
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
        /// <exception cref="ArgumentNullException">If data is null or empty</exception>
        /// <exception cref="ArgumentException">If recipeID or nutritionID are all ready set</exception>
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
                throw new ArgumentNullException("Ingredients, Meal Types, and Kitchenware cannot be empty");
            }
            if (recipe.RecipeId > 0 || recipe.NutritionId > 0 || nutrition.NutritionId > 0)
            {
                throw new ArgumentException("AddRecipe is not an UPDATE query. RecipeID and NutritionID should be set to 0 or negative");
            }
            try
            {
                //using (TransactionScope scope = new TransactionScope())
                //{
                    NutritionDAL nutritionDAL = new NutritionDAL();
                    recipe.NutritionId = nutritionDAL.AddNutrition(nutrition);

                    recipe.RecipeId = this.recipeDAL.AddRecipe(recipe);
                    if (recipe.RecipeImage != null)
                    {
                        this.recipeDAL.AddImage(recipe);
                    }

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
            }
            catch (TransactionAbortedException ex)
            {
                throw new TransactionAbortedException(ex.Message);
            }
            return true;
        }

        /// <summary>
        /// Deletes the recipe from the database
        /// </summary>
        /// <param name="user">User who is calling</param>
        /// <param name="recipe">Recipe to delete</param>
        /// <returns>Whether or not the recipe was deleted</returns>
        /// <exception cref="UnauthorizedAccessException">If user is not the creator or an admin</exception>
        /// <exception cref="ArgumentException">If recipeID is less than 1</exception>
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
            try
            {
                //using (TransactionScope scope = new TransactionScope())
                //{
                    NutritionDAL nutritionDAL = new NutritionDAL();
                    nutritionDAL.DeleteNutrition(recipe.NutritionId);

                    this.recipeDAL.DeleteImage(recipe.RecipeId);
                    this.recipeDAL.DeleteRecipeHasIngredient(recipe.RecipeId);
                    this.recipeDAL.DeleteRecipeIsATypeOfMeal(recipe.RecipeId);
                    this.recipeDAL.DeleteRecipeUsesKitchenware(recipe.RecipeId);

                    recipe.RecipeId = this.recipeDAL.AddRecipe(recipe);
                    //scope.Complete();
                //}
            }
            catch (TransactionAbortedException ex)
            {
                throw new TransactionAbortedException(ex.Message);
            }
            return true;
        }

        /// <see cref="RecipeDAL.UpdateAmountInRecipeHasIngredient(int, int, string)"/>
        /// <exception cref="ArgumentNullException">If parameters are null</exception>
        /// <exception cref="UnauthorizedAccessException">If user is not the creator or an admin</exception>
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
        /// <exception cref="UnauthorizedAccessException">If user is not the creator or an admin</exception>
        /// <exception cref="ArgumentNullException">If parameters are null or empty</exception>
        /// <exception cref="ArgumentException">If nutrition or recipe ID are less than 1 or mismatched</exception>
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
                throw new ArgumentNullException("Ingredients, Meal Types, and Kitchenware cannot be empty");
            }
            if (recipe.RecipeId < 1 || recipe.NutritionId < 1 || nutrition.NutritionId < 1)
            {
                throw new ArgumentException("RecipeID and NutritionID must be greater than zero");
            }
            if (recipe.NutritionId != nutrition.NutritionId)
            {
                throw new ArgumentException("Recipe and Nutrition must have same nutritionID");
            }

            try 
            {
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
            }
            catch (TransactionAbortedException ex)
            {
                throw new TransactionAbortedException(ex.Message);
            }

            return true;
        }

        public static void SetRecipeInstructions(string text)
        {
            recipeInstructions = text;
        }

        public static string GetRecipeInstructions()
        {
            return recipeInstructions;
        }
    }
}
