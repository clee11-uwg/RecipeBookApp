
namespace RecipeBookApp.Model
{
    public class Kitchenware
    {

        /// <summary>
        /// Cookware  attributes.
        /// </summary>
        public int KitchenwareId { get; set; }
        public string KitchenwareDetails { get; set; }
        public int NutritionId { get; internal set; }
        public string NutritionDetails { get; internal set; }
    }
}
