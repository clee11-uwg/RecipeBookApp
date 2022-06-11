using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using RecipeBookApp.Model;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Recipe table.
    /// </summary>
    public class RecipeDAL
    {
        public static List<Recipe> GetRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            string selectStatement = "SELECT * from RECIPES";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe
                            {
                                RecipeId = Convert.ToInt32(reader["RecipeId"]),
                                RecipeName = reader["Fname"].ToString(),
                                RecipeInstructions = reader["Lname"].ToString(),
                                CookingTime = Convert.ToInt32(reader["CookingTime"]),
                                NutritionId = Convert.ToInt32(reader["NutritionId"]),
                                EthnicId = Convert.ToInt32(reader["EthnicId"])
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
        public void AddRecipe(Recipe addRecipe){


        string addRecipeStatement = "INSERT INTO Recipe (RecipeName,RecipeInstructions,CookingTime,NutritionId, EthnicId) " +
                                     "VALUES(@RecipeName, @RecipeInstructions, @CookingTime, @NutritionId  , @EthnicId)";
            
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(addRecipeStatement, connection))
                {
                    selectCommand.Parameters.Add("@RecipeName", SqlDbType.VarChar);
                    selectCommand.Parameters["@RecipeName"].Value = addRecipe.RecipeName;

                    selectCommand.Parameters.Add("@RecipeInstructions", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = addRecipe.RecipeInstructions;

                    selectCommand.Parameters.Add("@CookingTime", SqlDbType.Int);
                    selectCommand.Parameters.Add("@CookingTime", SqlDbType.Int).Value = addRecipe.CookingTime;
                    selectCommand.Parameters.Add("@NutritionId", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NutritionId", SqlDbType.VarChar).Value = addRecipe.NutritionId;

                    selectCommand.Parameters.Add("@EthnicId", SqlDbType.Int);
                    selectCommand.Parameters.Add("@EthnicId", SqlDbType.Int).Value = addRecipe.EthnicId;

                    selectCommand.ExecuteNonQuery();

                }
            }
        }






    }
}
