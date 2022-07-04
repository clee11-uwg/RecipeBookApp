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
        public int Carbohydrate { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Alcohol { get; set; }
        public int Calories { get; set; }
        public string ServingSize { get; set; }

    }
}
