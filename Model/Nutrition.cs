using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookApp.Model
{
    /// <summary>
    /// Models the Nutrition table found in the recipe_app database
    /// </summary>
    public class Nutrition
    {
        /// <summary>
        /// Nutrition  attributes.
        /// </summary>
        public int NutritionId { get; set; }
        public string Carbohydrate { get; set; }
        public string Protein { get; set; }
        public string Fat { get; set; }
        public string Alcohol { get; set; }
        public string Vitamin { get; set; }
        public string Mineral { get; set; }
        public string Fiber { get; set; }
        public string Water { get; set; }

    }
}
