using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBookApp.Controller
{

    /// <summary>
    /// Controller class connecting GUI with Type Of Meal queries
    /// </summary>
    public class TypeOfMealController
    {
        private readonly TypeOfMealDAL mealTypeDAL;

        /// <summary>
        /// Instantiate variables
        /// </summary>
        public TypeOfMealController()
        {
            this.mealTypeDAL = new TypeOfMealDAL();
        }

        /// <summary>
        /// Gets all Meal Types from the database table.
        /// </summary>
        /// <returns>List of all Meal Types from database </returns>
        public List<MealType> GetMealTypes()
        {
            return this.mealTypeDAL.GetMealTypes();
        }

        /// <summary>
        /// Gets the meal type data for the search ID.
        /// </summary>
        /// <param name="searchRecipeID">ID of the recipe</param>
        /// <returns>Meal type data found in the database</returns>
        public List<MealType> GetMealTypes(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID must be greater than zero");
            }
            return this.mealTypeDAL.GetMealTypesByRecipe(searchRecipeID);
        }

        /// <see cref="TypeOfMealDAL.GetMealTypeByName"/>
        public MealType GetMealTypeByName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException("Name cannot be null or empty");
            }
            return this.mealTypeDAL.GetMealTypeByName(name);
        }

    }
}