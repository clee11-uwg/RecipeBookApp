using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;

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

        /// <see cref="TypeOfFoodDAL.GetFoodTypes"/>
        public List<FoodType> GetFoodTypes()
        {
            return this.foodTypeDAL.GetFoodTypes();
        }

        /// <see cref="TypeOfFoodDAL.GetFoodTypes(int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If searchRecipeID is less than 1</exception>
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