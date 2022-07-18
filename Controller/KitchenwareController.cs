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

        /// <see cref="KitchenwareDAL.GetKitchenwares"/>
        public List<Kitchenware> GetKitchenware()
        {
            return kitchenwareDAL.GetKitchenwares();
        }

        /// <see cref="KitchenwareDAL.GetKitchenwareByRecipeID(int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If searchRecipeID is less than 1</exception>
        public List<Kitchenware> GetKitchenware(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID must be greater than zero");
            }
            return this.kitchenwareDAL.GetKitchenwareByRecipeID(searchRecipeID);
        }

        /// <see cref="KitchenwareDAL.GetKitchenwareByName(string)"
        public Kitchenware GetKitchenwareByName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException("Name cannot be null or empty");
            }
            return this.kitchenwareDAL.GetKitchenwareByName(name);
        }
    }
}
