using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBookApp.Controller
{

    /// <summary>
    /// Controller class connecting GUI with Type Of Food queries
    /// </summary>
    public class TypeOfFoodController
    {
        private readonly TypeOfFoodDAL foodTypeDAL;

        /// <summary>
        /// Instantiate variables
        /// </summary>
        public TypeOfFoodController()
        {
            this.foodTypeDAL = new TypeOfFoodDAL();
        }

        /// <summary>
        /// Gets all Food Types from the database table.
        /// </summary>
        /// <returns>List of all Food Types from database </returns>
        public List<FoodType> GetFoodTypes()
        {
            return this.foodTypeDAL.GetFoodTypes();
        }

        /// <summary>
        /// Gets the food type data for the search ID.
        /// </summary>
        /// <param name="searchRecipeID">ID of the recipe</param>
        /// <returns>Food type data found in the database</returns>
        public List<FoodType> GetFoodTypes(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID must be greater than zero");
            }
            return this.foodTypeDAL.GetFoodTypes(searchRecipeID);
        }
    }
}