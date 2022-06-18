using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBookApp.Controller
{
    public class KitchenwareController
    {
        private readonly KitchenwareDAL kitchenwareDAL;
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

            if (!this.kitchenwareDAL.GetKitchenwares().Any())
            {
                throw new ArgumentNullException("No KitchenWares found on the database");

            }
            return kitchenwareDAL.GetKitchenwares();
        }

        /// <summary>
        /// Gets the kitchenware for the search ID.
        /// </summary>
        /// <returns>kitchenware found in the database</returns>
        public Kitchenware GetKitchenware(int searchRecipeID)
        {
            Kitchenware kitchen = this.kitchenwareDAL.GetKitchenware(searchRecipeID);
            if (kitchen == null)
            {
                throw new ArgumentNullException("No kitchenware found on the database");

            }
            return kitchen;
        }

    }
}
