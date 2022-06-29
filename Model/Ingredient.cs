namespace RecipeBookApp.Model
{
    /// <summary>
    /// Models the Ingredient table in the recipe_app database
    /// </summary>
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
