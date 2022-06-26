using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBookApp.Controller
{

   /// <summary>
   /// Controller class for the Nutritions 
   /// </summary>
    public class NutritionController
    {
        private readonly NutritionDAL nutritionDAL;
        
        /// <summary>
        /// Constructor for the nutritions 
        /// </summary>
        public NutritionController()
        {
            this.nutritionDAL = new NutritionDAL();
        }

        /// <summary>
        /// Gets all Nutrition from the database table.
        /// </summary>
        /// <returns>List of all Nutritions from database </returns>
        public List<Nutrition> GetNutritions()
        {
            return this.nutritionDAL.GetNutritions();
        }

        /// <summary>
        /// Gets the Nutrition data for the search ID.
        /// </summary>
        /// <param name="searchRecipeID">ID of the recipe</param>
        /// <returns>Nutrition data found in the database</returns>
        public List<Nutrition> GetNutrition(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID must be greater than zero");
            }
            return this.nutritionDAL.GetNutrition(searchRecipeID);
        }



    }
}
