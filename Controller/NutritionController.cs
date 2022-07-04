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
        /// <param name="sort">What parameter of Nutrition to order by</param>
        /// <returns>List of all Nutritions from database </returns>
        public List<Nutrition> GetNutritions(string sort)
        {
            if (string.IsNullOrEmpty(sort))
            {
                throw new ArgumentNullException("sort must be an attribute of Nutrition");
            }
            if (sort != "id" || sort != "carbohydrate" || sort != "protein" || sort != "fat" || 
                    sort != "alcohol" || sort != "calories" || sort != "serving_size")
            {
                throw new ArgumentException("sort must be an attribute of Nutrition");
            }
            return this.nutritionDAL.GetNutritions(sort);
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
