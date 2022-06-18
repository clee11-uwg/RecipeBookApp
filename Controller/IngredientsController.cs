using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBookApp.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the Ingredients application
    /// and the RecipeDAL.
    /// </summary>
    public class IngredientsController
    {

        private readonly IngredientsDAL ingredientsDAL;


        public IngredientsController()
        {
            this.ingredientsDAL = new IngredientsDAL();
        }

        /// <summary>
        /// Gets all Recipe  Recipe table.
        /// </summary>
        /// <returns>List of all Recipes from database </returns>
        public List<Ingredient> GetRecipes()
        {
            List<Ingredient> ingredientsList = this.ingredientsDAL.GetIngredients();

            if (!ingredientsList.Any())
            {
                throw new ArgumentNullException("No Recipes found on the database");

            }
            return ingredientsList;
        }

        /// <summary>
        /// Gets the recipe for the search ID.
        /// </summary>
        /// <returns>Recipe found in the database</returns>
        public Ingredient GetIngredient(int searchRecipeID)
        {
            Ingredient foundIngredient = this.ingredientsDAL.GetIngredient(searchRecipeID);
            if (foundIngredient == null)
            {
                throw new ArgumentNullException("No Ingredient found on the database");

            }
            return foundIngredient;
        }


    }
}
