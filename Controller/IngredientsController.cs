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

        /// <summary>
        /// Instantiaties instance variables
        /// </summary>
        public IngredientsController()
        {
            this.ingredientsDAL = new IngredientsDAL();
        }

        /// <summary>
        /// Gets all Ingredients from the database table.
        /// </summary>
        /// <returns>List of all Ingredients from database </returns>
        public List<Ingredient> GetIngredients()
        {
            return this.ingredientsDAL.GetIngredients();
        }

        /// <summary>
        /// Gets the Ingredient for the search ID.
        /// </summary>
        /// <param name="searchRecipeID">ID of the recipe</param>
        /// <returns>Ingredient found in the database</returns>
        public List<Ingredient> GetIngredient(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID cannot be less than 1");
            }
            return this.ingredientsDAL.GetIngredient(searchRecipeID);
        }
    }
}
