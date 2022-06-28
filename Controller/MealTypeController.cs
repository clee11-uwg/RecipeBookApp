using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBookApp.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the Recipe application
    /// and the MealTypeDAL. 
    /// </summary>
    public class MealTypeController
    {

        private readonly MealTypeDAL mealDAL;
        /// <summary>
        /// Constructor for AllergenController
        /// </summary>
        public MealTypeController()
        {
            this.mealDAL = new MealTypeDAL();
        }

        /// <summary>
        /// Gets all Meals for the Recipes .
        /// </summary>
        /// <returns>List of all meals from database </returns>
        public List<MealType> GetMeals()
        {
            return this.mealDAL.GetMealTypes();
        }

    }
}
