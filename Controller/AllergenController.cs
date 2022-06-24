
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
            return this.allergenDAL.GetAllergens();
        }

        /// <summary>
        /// Gets the Allergen for the search ID.
        /// </summary>
        /// <returns>Allergen found in the database</returns>
        public Allergen GetAllergen(int searchRecipeID)
        {
            if (int < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID cannot be less than 1")
            }
            return this.allergenDAL.GetRecipeAllergen(searchRecipeID);
        }

        /// <summary>
        /// Gets all Allergens for this ingredient ID
        /// </summary>
        /// <param name="ingredientID">ID of the ingredient</param>
        /// <returns>List of Allergens for this ingredient</returns>
        public List<Allergen> getAllergensOfIngredient(int ingredientID)
        {
            if (int < 1)
            {
                throw new ArgumentOutOfRangeException("Ingredient ID cannot be less than 1")
            }
            return this.allergenDAL.GetAllergensOfIngredient(ingredientID)
        }
    }
}
