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

        /// <see cref="IngredientsDAL.GetIngredients"/>
        public List<Ingredient> GetIngredients()
        {
            return this.ingredientsDAL.GetIngredients();
        }

        /// <see cref="IngredientsDAL.GetIngredientByRecipeID(int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If searchRecipeID is less than 1</exception>
        public List<Ingredient> GetIngredient(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID cannot be less than 1");
            }
            return this.ingredientsDAL.GetIngredientByRecipeID(searchRecipeID);
        }

        /// <see cref="IngredientsDAL.GetIngredientByIngredientName"/>
        /// <exception cref="NullReferenceException">If name is null or empty</exception>
        public Ingredient GetIngredientByIngredientID(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException("Name cannot be empty or null");
            }
            return this.ingredientsDAL.GetIngredientByIngredientName(name);
        }
    }
}
