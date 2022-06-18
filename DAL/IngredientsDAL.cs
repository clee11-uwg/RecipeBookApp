using MySql.Data.MySqlClient;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookApp.DAL
{
    public class IngredientsDAL
    {

        
        /// <summary>
        /// This method to get the recipe based on the  search ID
        /// </summary>
        /// <returns></returns>
        public Recipe GetRecipe(int recipeID)
        {
            Recipe recipe = null;
            string selectStatement = "	SELECT recipe.id, recipe.`Name`, recipe.Instructions, recipe.cooktime, recipe.nutritionID, recipe.ethnicOriginID" +
                      "FROM recipe    WHERE recipe.id = recipeID;";

            using (MySqlConnection connection = DBConnection.GetConnection())
            {
                using (MySqlCommand selectCommand = new MySqlCommand(selectStatement, connection))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        recipe = new Recipe
                        {
                            RecipeId = Convert.ToInt32(reader["id"]),
                            RecipeName = reader["Name"].ToString(),
                            RecipeInstructions = reader["Instructions"].ToString(),
                            CookingTime = Convert.ToInt32(reader["cooktime"]),
                            NutritionId = Convert.ToInt32(reader["nutritionID"]),
                            EthnicId = Convert.ToInt32(reader["ethnicOriginID"])
                        };

                    }
                }
            }

            return recipe;
        }


    }
}
