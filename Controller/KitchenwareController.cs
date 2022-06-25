using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBookApp.Controller
{
    /// <summary>
    /// Connects the RecipeApp with the database queries for kitchenware
    /// </summary>
    public class KitchenwareController
    {
        private readonly KitchenwareDAL kitchenwareDAL;

        /// <summary>
        /// Instantiate instance variables
        /// </summary>
        public KitchenwareController()
        {
            this.kitchenwareDAL = new KitchenwareDAL();
        }

        /// <summary>
        /// Gets all kitchenware.
        /// </summary>
        /// <returns>List of all kitchenware from database </returns>
        public List<Kitchenware> GetKitchenware()
        {
            return kitchenwareDAL.GetKitchenwares();
        }

        /// <summary>
        /// Finds all kitchenware needed to cook said recipe
        /// <param name="recipeID">Id of recipe</param>
        /// <returns>Kitchenware associated with recipe</returns>
        public List<Kitchenware> GetKitchenware(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID must be greater than zero")
            }
            return this.kitchenwareDAL.GetKitchenware(searchRecipeID);
        }

    }
}
