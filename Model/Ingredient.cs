using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookApp.Model
{
    public class Ingredient
    {

        /// <summary>
        /// Ingredient  attributes.
        /// </summary>
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public int FoodId { get; set; }
    }
}
