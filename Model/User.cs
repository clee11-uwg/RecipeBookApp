namespace RecipeBookApp.Model
{
    /// <summary>
    /// Models the User table in the recipe_app database
    /// </summary>
    public class User
    {
        /// <summary>
        /// User  attributes.
        /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Is_Admin { get; set; }
    }
}
