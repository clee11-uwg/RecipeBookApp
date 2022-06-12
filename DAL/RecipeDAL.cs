using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RecipeBookApp.Model;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Recipe table.
    /// </summary>
    public class RecipeDAL
    {
        public List<Recipe> GetRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            string selectStatement = "SELECT * from recipe;";

            using (MySqlConnection connection = DBConnection.GetConnection())
            {
                using (MySqlCommand selectCommand = new MySqlCommand(selectStatement, connection))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe
                            {
                                RecipeId = Convert.ToInt32(reader["id"]),
                                RecipeName = reader["Name"].ToString(),
                                RecipeInstructions = reader["Instructions"].ToString(),
                                CookingTime = Convert.ToInt32(reader["cooktime"]),
                                NutritionId = Convert.ToInt32(reader["nutritionID"]),
                                EthnicId = Convert.ToInt32(reader["ethnicOriginID"])
                            };

                            recipes.Add(recipe);
                        }
                    }
                }
            }

            return recipes;
        }

        /// <summary>
        /// Adds the recipe.
        /// </summary>
        /// <param name="addRecipe">The add recipe.</param>
        public static void AddRecipe(Recipe addRecipe){


        string addRecipeStatement = "INSERT INTO Recipe (RecipeName,RecipeInstructions,CookingTime,NutritionId, EthnicId) " +
                                     "VALUES(@RecipeName, @RecipeInstructions, @CookingTime, @NutritionId  , @EthnicId)";
            
            using (MySqlConnection connection = DBConnection.GetConnection())
            {
                using (MySqlCommand selectCommand = new MySqlCommand(addRecipeStatement, connection))
                {
                    selectCommand.Parameters.Add("@RecipeName", MySqlDbType.VarChar);
                    selectCommand.Parameters["@RecipeName"].Value = addRecipe.RecipeName;

                    selectCommand.Parameters.Add("@RecipeInstructions", MySqlDbType.VarChar);
                    selectCommand.Parameters.Add("@RecipeInstructions", MySqlDbType.VarChar).Value = addRecipe.RecipeInstructions;

                    selectCommand.Parameters.Add("@CookingTime", MySqlDbType.Int32);
                    selectCommand.Parameters.Add("@CookingTime", MySqlDbType.Int32).Value = addRecipe.CookingTime;
                    selectCommand.Parameters.Add("@NutritionId", MySqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NutritionId", MySqlDbType.VarChar).Value = addRecipe.NutritionId;

                    selectCommand.Parameters.Add("@EthnicId", MySqlDbType.Int32);
                    selectCommand.Parameters.Add("@EthnicId", MySqlDbType.Int32).Value = addRecipe.EthnicId;

                    selectCommand.ExecuteNonQuery();

                }
            }
        }

        /// <summary>
        /// Updates the employee details.
        /// </summary>
        /// <param name="oldRecipe">The old recipe.</param>
        /// <param name="newRecipe">The new recipe.</param>
        /// <returns></returns>
        public static bool UpdateRecipe(Recipe oldRecipe, Recipe newRecipe)
        {
            string selectStatement = "UPDATE Recipe SET " +
                                        "RecipeName = @NewRecipeName, RecipeInstructions = @NewRecipeInstructions, " +
                                        "CookingTime = @NewCookingTime, NutritionId = @NewNutritionId, EthnicId = @NewEthnicId" +
                                        "WHERE RecipeID = @OldRecipeID " +
                                            "AND RecipeName = @OldRecipeName AND " +
                                        "RecipeInstructions = @OldRecipeInstructions " +
                                            "AND CookingTime = @OldCookingTime AND " +
                                        "NutritionId = @OldNutritionId AND EthnicId = @OldEthnicId ";

            using (MySqlConnection connection = DBConnection.GetConnection())
            {
                using (MySqlCommand selectCommand = new MySqlCommand(selectStatement, connection))
                {
                    // Old Recipe details Mappings
                    selectCommand.Parameters.Add("@OldRecipeName", MySqlDbType.VarChar);
                    selectCommand.Parameters["@OldRecipeName"].Value = oldRecipe.RecipeName;

                    selectCommand.Parameters.Add("@OldRecipeInstructions", MySqlDbType.VarChar);
                    selectCommand.Parameters["@OldRecipeInstructions"].Value = oldRecipe.RecipeInstructions;

                    selectCommand.Parameters.Add("@OldCookingTime", MySqlDbType.Int32);
                    selectCommand.Parameters["@OldCookingTime"].Value = oldRecipe.CookingTime;
                    selectCommand.Parameters.Add("@OldNutritionId", MySqlDbType.Int32);
                    selectCommand.Parameters["@OldNutritionId"].Value = oldRecipe.NutritionId;
                    selectCommand.Parameters.Add("@OldEthnicId", MySqlDbType.Int32);
                    selectCommand.Parameters["@OldEthnicId"].Value = oldRecipe.EthnicId;

                    // New Recipe details Mappings
                    selectCommand.Parameters.Add("@NewRecipeName", MySqlDbType.VarChar);
                    selectCommand.Parameters["@NewRecipeName"].Value = newRecipe.RecipeName;

                    selectCommand.Parameters.Add("@NewRecipeInstructions", MySqlDbType.VarChar);
                    selectCommand.Parameters["@NewRecipeInstructions"].Value = oldRecipe.RecipeInstructions;

                    selectCommand.Parameters.Add("@NewCookingTime", MySqlDbType.Int32);
                    selectCommand.Parameters["@NewCookingTime"].Value = oldRecipe.CookingTime;
                    selectCommand.Parameters.Add("@NewNutritionId", MySqlDbType.Int32);
                    selectCommand.Parameters["@NewNutritionId"].Value = oldRecipe.NutritionId;
                    selectCommand.Parameters.Add("@EthnicId", MySqlDbType.Int32);
                    selectCommand.Parameters["@NewEthnicId"].Value = oldRecipe.EthnicId;

                    
                    int resultCount = selectCommand.ExecuteNonQuery();
                    if (resultCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }






    }
}
