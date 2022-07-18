using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;

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
        /// Constructor for AllergenController
        /// </summary>
        public AllergenController()
        {
            this.allergenDAL = new AllergenDAL();
        }

        /// <see cref="AllergenDAL.GetAllergens"/>
        public List<Allergen> GetAllergens()
        {
            return this.allergenDAL.GetAllergens();
        }

        /// <see cref="AllergenDAL.GetRecipeAllergen(int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If searchRecipeID is less than 1</exception>
        public List<Allergen> GetAllergen(int searchRecipeID)
        {
            if (searchRecipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID cannot be less than 1");
            }
            return this.allergenDAL.GetRecipeAllergen(searchRecipeID);
        }

        /// <see cref="AllergenDAL.GetAllergensOfIngredient(int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If ingredientID is less than 1</exception>
        public List<Allergen> getAllergensOfIngredient(int ingredientID)
        {
            if (ingredientID < 1)
            {
                throw new ArgumentOutOfRangeException("Ingredient ID cannot be less than 1");
            }
            return this.allergenDAL.GetAllergensOfIngredient(ingredientID);
        }
    }
}
