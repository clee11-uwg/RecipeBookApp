using System;
using System.Drawing;
using System.IO;

namespace RecipeBookApp.Model
{
    /// <summary>
    /// This is a DB model class for Recipe
    /// </summary>
    public class Recipe
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

        public Image RecipeImage  { get; set;}

    }
}
