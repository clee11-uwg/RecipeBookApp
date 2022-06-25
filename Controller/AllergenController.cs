
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
    /// and the AllergenDAL. 
    /// </summary>
    public class AllergenController
    {

        private readonly AllergenDAL allergenDAL;
        /// <summary>
        /// Constructor for Allergen
        /// </summary>
        public AllergenController()
        {
            this.allergenDAL = new AllergenDAL();
        }

        /// <summary>
        /// Gets all Allergens for the Recipes .
        /// </summary>
        /// <returns>List of all allergens from database </returns>
        public List<Allergen> GetAllergens()
        {
            List<Allergen> allergenList = this.allergenDAL.GetAllergens();
            if (!allergenList.Any())
            {
                throw new ArgumentNullException("No Allergen found on the database");

            }
            return allergenList;
        }

        /// <summary>
        /// Gets the Allergen for the search ID.
        /// </summary>
        /// <returns>Allergen found in the database</returns>
        public Allergen GetAllergen(int searchRecipeID)
        {
            Allergen allergenDetails = this.allergenDAL.GetRecipeAllergen(searchRecipeID);
            if (allergenDetails == null)
            {
                throw new ArgumentNullException("No allergen deatils found on the database");

            }
            return allergenDetails;
        }


    }
}
