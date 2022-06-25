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
            List<Nutrition> nutritionList = this.nutritionDAL.GetNutritions();

            if (!nutritionList.Any())
            {
                throw new ArgumentNullException("No Nutritions found on the database");

            }
            return nutritionList;
        }

        /// <summary>
        /// Gets the Nutrition for the search ID.
        /// </summary>
        /// <param name="searchRecipeID">ID of the recipe</param>
        /// <returns>Nutrition found in the database</returns>
        public Nutrition GetNutrition(int searchRecipeID)
        {
            Nutrition foundNutrition= this.nutritionDAL.GetNutrition(searchRecipeID);
            if (foundNutrition == null)
            {
                throw new ArgumentNullException("No Nutrition found on the database");

            }
            return foundNutrition;
        }



    }
}
