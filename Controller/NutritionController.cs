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

        /// <see cref="NutritionDAL.GetNutritions(string)"/>
        /// <exception cref="ArgumentNullException">If string is null or empty</exception>
        /// <exception cref="ArgumentException">If string does not equal one of the attributes of Nutrition</exception>
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

        /// <see cref="NutritionDAL.GetNutritions(string)"/>
        /// <exception cref="ArgumentOutOfRangeException">If recipeID is less than 1</exception>
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
