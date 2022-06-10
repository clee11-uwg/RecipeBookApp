using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

    }
}
