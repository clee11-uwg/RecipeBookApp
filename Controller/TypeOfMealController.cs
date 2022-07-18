using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;

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

        /// <see cref="TypeOfMealDAL.GetMealTypes"/>
        public List<MealType> GetMealTypes()
        {
            return this.mealTypeDAL.GetMealTypes();
        }

        /// <see cref="TypeOfMealDAL.GetMealTypesByRecipe(int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If searchRecipeID is less than 1</exception>
        public List<MealType> GetMealTypes(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID must be greater than zero");
            }
            return this.mealTypeDAL.GetMealTypesByRecipe(searchRecipeID);
        }

        /// <see cref="TypeOfMealDAL.GetMealTypeByName(string)"/>
        /// <exception cref="NullReferenceException">If name is null or empty</exception>
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