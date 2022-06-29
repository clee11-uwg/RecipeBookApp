namespace RecipeBookApp.Model
{
    /// <summary>
    /// Models the Type_of_Food table in the recipe_app database
    /// </summary>
    public class FoodType
    {
        /// <summary>
        /// FoodType  attributes.
        /// </summary>
        public int FoodId{ get; set; }
        public string TypeOfFood { get; set; }
    }
}
