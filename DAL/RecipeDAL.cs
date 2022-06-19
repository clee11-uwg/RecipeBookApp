using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using RecipeBookApp.Model;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Recipe table.
    /// </summary>
    public class RecipeDAL
    {
        /// <summary>
        /// This method to get the list of recipes avilable in the recipe database
        /// </summary>
        /// <returns></returns>
        public List<Recipe> GetRecipes()
        {

            string workingDirectory = Environment.CurrentDirectory;
            string path = Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"Data\", "sampleimage.jpg");
            List<Recipe> recipes = new List<Recipe>();
            string selectStatement = "SELECT public_recipe.id, public_recipe.`Name`, public_recipe.Instructions, " +
                "public_recipe.cooktime, public_recipe.nutritionID,	public_recipe.ethnicOriginID     FROM public_recipe; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
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
                                EthnicId = Convert.ToInt32(reader["ethnicOriginID"]),
                                RecipeImage = Image.FromFile(path)
                            };

                            recipes.Add(recipe);
                        }
                    }
                }
            }

            return recipes;
        }

        /// <summary>
        /// This method to get the recipe based on the  search ID
        /// </summary>
        /// <returns></returns>
        public Recipe GetRecipe(int recipeID)
        {
            Recipe recipe = null;
           string selectStatement = "	SELECT recipe.id, recipe.`Name`, recipe.Instructions, recipe.cooktime, recipe.nutritionID, recipe.ethnicOriginID" +
                     "FROM recipe    WHERE recipe.id = recipeID;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
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


        /// <summary>
        /// Adds the new recipe.
        /// </summary>
        /// <param name="addRecipe">The add recipe.</param>
        public static void AddRecipe(Recipe addRecipe){

        string addRecipeStatement = "INSERT INTO Recipe (RecipeName,RecipeInstructions,CookingTime,NutritionId, EthnicId) " +
                                     "VALUES(@RecipeName, @RecipeInstructions, @CookingTime, @NutritionId  , @EthnicId)";
            
            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(addRecipeStatement, connection))
                {
                    selectCommand.Parameters.Add("@RecipeName", DbType.String);
                    selectCommand.Parameters["@RecipeName"].Value = addRecipe.RecipeName;

                    selectCommand.Parameters.Add("@RecipeInstructions", DbType.String);
                    selectCommand.Parameters.Add("@RecipeInstructions", DbType.String).Value = addRecipe.RecipeInstructions;

                    selectCommand.Parameters.Add("@CookingTime", DbType.Int32);
                    selectCommand.Parameters.Add("@CookingTime", DbType.Int32).Value = addRecipe.CookingTime;
                    selectCommand.Parameters.Add("@NutritionId", DbType.String);
                    selectCommand.Parameters.Add("@NutritionId", DbType.String).Value = addRecipe.NutritionId;

                    selectCommand.Parameters.Add("@EthnicId", DbType.Int32);
                    selectCommand.Parameters.Add("@EthnicId", DbType.Int32).Value = addRecipe.EthnicId;

                    selectCommand.ExecuteNonQuery();

                }
            }
        }

        /// <summary>
        /// Updates the Recipe details.
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

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    // Old Recipe details Mappings
                    selectCommand.Parameters.Add("@OldRecipeName", DbType.String);
                    selectCommand.Parameters["@OldRecipeName"].Value = oldRecipe.RecipeName;

                    selectCommand.Parameters.Add("@OldRecipeInstructions", DbType.String);
                    selectCommand.Parameters["@OldRecipeInstructions"].Value = oldRecipe.RecipeInstructions;

                    selectCommand.Parameters.Add("@OldCookingTime", DbType.Int32);
                    selectCommand.Parameters["@OldCookingTime"].Value = oldRecipe.CookingTime;
                    selectCommand.Parameters.Add("@OldNutritionId", DbType.Int32);
                    selectCommand.Parameters["@OldNutritionId"].Value = oldRecipe.NutritionId;
                    selectCommand.Parameters.Add("@OldEthnicId", DbType.Int32);
                    selectCommand.Parameters["@OldEthnicId"].Value = oldRecipe.EthnicId;

                    // New Recipe details Mappings
                    selectCommand.Parameters.Add("@NewRecipeName", DbType.String);
                    selectCommand.Parameters["@NewRecipeName"].Value = newRecipe.RecipeName;
                    selectCommand.Parameters.Add("@NewRecipeInstructions", DbType.String);
                    selectCommand.Parameters["@NewRecipeInstructions"].Value = oldRecipe.RecipeInstructions;
                    selectCommand.Parameters.Add("@NewCookingTime", DbType.Int32);
                    selectCommand.Parameters["@NewCookingTime"].Value = oldRecipe.CookingTime;
                    selectCommand.Parameters.Add("@NewNutritionId", DbType.Int32);
                    selectCommand.Parameters["@NewNutritionId"].Value = oldRecipe.NutritionId;
                    selectCommand.Parameters.Add("@EthnicId", DbType.Int32);
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


        /// <summary>
        /// Delete the Recipe details.
        ///
        public  bool DeleteRecipe(Recipe deleteRecipe)
        {
            return true;
            
        }

    }
}
