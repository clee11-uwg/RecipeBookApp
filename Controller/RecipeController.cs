
using System;
using System.Collections.Generic;
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

        public RecipeController()
        {
            this.recipeDAL = new RecipeDAL();
        }

        /// <summary>
        /// Gets all Recipe  Recipe table.
        /// </summary>
        /// <returns>List of all Recipes from database </returns>
        public List<Recipe> GetRecipes()
        {

            if (!this.recipeDAL.GetRecipes().Any())
            {
                throw new ArgumentNullException("No Recipes found on the database");

            }
            return this.recipeDAL.GetRecipes();
        }

        /// <summary>
        /// Gets the recipe for the search ID.
        /// </summary>
        /// <returns>Recipe found in the database</returns>
        public Recipe GetRecipe(int searchRecipeID)
        {
            Recipe foundRecipe = this.recipeDAL.GetRecipe(searchRecipeID);
            if (foundRecipe == null)
            {
                throw new ArgumentNullException("No Recipe found on the database");

            }
            return foundRecipe;
        }


        /// <summary>
        /// Gets the recipe for the search ID.
        /// </summary>
        /// <returns>Recipe found in the database</returns>
        public List<Recipe> GetRecipeSearch(string searchUserInput)
        {
            List<Recipe> foundRecipeList = this.recipeDAL.GetSearchRecipe(searchUserInput);
           
            return foundRecipeList;
        }



        /// <summary>
        /// Updates the recipe.
        /// </summary>
        /// <param name="newUpdateRecipe">The new update recipe.</param>
        /// <param name="oldUpdateRecipe">The old update recipe.</param>
        /// <returns></returns>
        public void UpdateRecipe(Recipe newUpdateRecipe, Recipe oldUpdateRecipe)
        {
            if (newUpdateRecipe == null || oldUpdateRecipe == null)
            {
                throw new ArgumentNullException("Recipe cannot be updated , as current or new data is not found or updated");

            }
            RecipeDAL.UpdateRecipe(newUpdateRecipe, oldUpdateRecipe);
        }

        /// <summary>
        /// Adds the recipe.
        /// </summary>
        /// <param name="newRecipe">The new recipe.</param>
        public void AddRecipe(Recipe newRecipe)
        {
             RecipeDAL.AddRecipe(newRecipe);
        }

       


        /// <summary>
        /// Deletes the recipes.
        /// </summary>
        /// <param name="deleteRecipeId">The delete recipe identifier.</param>
        /// <returns></returns>
        public bool DeleteRecipe(Recipe deleteRecipe)
        {
            if (deleteRecipe == null)
            {
                throw new ArgumentNullException("Delete of a recipe or restore cannot be performed ");
            }

             return this.recipeDAL.DeleteRecipe(deleteRecipe);
            // return RecipeDAL.DeleteRecipe(deleteRecipeId);
        }
    }
}
