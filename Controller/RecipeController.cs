
using System.Collections.Generic;
using RecipeBookApp.DAL;
using RecipeBookApp.Model;

namespace RecipeBookApp.Controller
{
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
        /// <returns>List of RentMe employees</returns>
        public List<Recipe> GetRecipes()
        {
            return this.recipeDAL.GetRecipes();
        }


        /// <summary>
        /// Updates the recipe.
        /// </summary>
        /// <param name="newUpdateRecipe">The new update recipe.</param>
        /// <param name="oldUpdateRecipe">The old update recipe.</param>
        /// <returns></returns>
        public void UpdateRecipe(Recipe newUpdateRecipe, Recipe oldUpdateRecipe)
        {
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
        public void DeleteRecipe(int deleteRecipeId)
        {
           // return RecipeDAL.DeleteRecipe(deleteRecipeId);
        }
    }
}
