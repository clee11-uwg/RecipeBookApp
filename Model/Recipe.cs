using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookApp.Model
{
    public  class Recipe
    {
        /// <summary>
        /// Recipe  attributes.
        /// </summary>
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeInstructions { get; set; }
        public int CookingTime { get; set; }
        public int NutritionId { get; set; }
        public int EthnicId { get; set; }
    }
}
