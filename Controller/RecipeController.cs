
using System.Collections.Generic;

using RecipeBookApp.DAL;
using RecipeBookApp.Model;

namespace RecipeBookApp.Controller
{
    public class RecipeController
    {
        /// <summary>
        /// Gets all Recipe  Recipe table.
        /// </summary>
        /// <returns>List of RentMe employees</returns>
        public List<Recipe> GetRecipes()
        {
            return RecipeDAL.GetRecipes();
        }

       
    }
}
