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
        /// <returns>List of all recipes in database</returns>
        public List<Recipe> GetRecipes()
        {

            //string workingDirectory = Environment.CurrentDirectory;
            //string path = Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"Data\", "sampleimage.jpg");
            List<Recipe> recipes = new List<Recipe>();
            string selectStatement = "SELECT r.id, r.`Name`, r.Instructions, " +
                "r.cooktime, r.nutritionID, r.ethnicOriginID, i.image FROM recipe r JOIN image i " +
                "ON r.ID = i.recipeID;";
                

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Set up byte array and stream to convert BLOB image from db into something readable and can be displayed
                            byte[] image_byte = (byte[])reader["image"];
                            MemoryStream ms = new MemoryStream(image_byte);
                            Recipe recipe = new Recipe
                            {
                                RecipeId = Convert.ToInt32(reader["id"]),
                                RecipeName = reader["Name"].ToString(),
                                RecipeInstructions = reader["Instructions"].ToString(),
                                CookingTime = Convert.ToInt32(reader["cooktime"]),
                                NutritionId = Convert.ToInt32(reader["nutritionID"]),
                                EthnicId = Convert.ToInt32(reader["ethnicOriginID"]),
                                RecipeImage = Image.FromStream(ms)
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
        /// <returns>The recipe of the given id</returns>
        public Recipe GetRecipe(int recipeID)
        {
            Recipe recipe = new Recipe();
            string selectStatement = @"SELECT recipe.id, recipe.`Name`, recipe.Instructions, recipe.cooktime, 
                                        recipe.nutritionID, recipe.ethnicOriginID, image.image
                                    FROM recipe    
                                        JOIN image ON recipe.id = image.recipeID
                                    WHERE recipe.id = @recipeID;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {

                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            byte[] image_byte = (byte[])reader["image"];
                            MemoryStream ms = new MemoryStream(image_byte);
                            {
                                recipe.RecipeId = Convert.ToInt32(reader["id"]);
                                recipe.RecipeName = reader["Name"].ToString();
                                recipe.RecipeInstructions = reader["Instructions"].ToString();
                                recipe.CookingTime = Convert.ToInt32(reader["cooktime"]);
                                recipe.NutritionId = Convert.ToInt32(reader["nutritionID"]);
                                recipe.EthnicId = Convert.ToInt32(reader["ethnicOriginID"]);
                                recipe.RecipeImage = Image.FromStream(ms);
                            };
                        }
                    }
                }
            }

            return recipe;
        }

        /// <summary>
        /// Gets the list of recipes without the undesired allergen
        /// </summary>
        /// <param name="allergenID">Undesired allergen</param>
        /// <returns>List of Recipes</returns>
        public List<Recipe> GetRecipesWithoutAllergen(int allergenID)
        {
            List<Recipe> recipes = new List<Recipe>();
            string selectStatement = @"	DROP TABLE IF EXISTS tempAllergicRecipes;

                                    CREATE TEMPORARY TABLE tempAllergicRecipes AS
                                    SELECT recipe.id AS `id`
                                    FROM recipe
                                        JOIN nutrition ON nutrition.id = recipe.nutritionID
                                        JOIN ethnic_origin ON recipe.ethnicOriginID = ethnic_origin.id
                                        JOIN recipe_has_ingredient ON recipe.id = recipe_has_ingredient.recipeID
                                        JOIN ingredient ON ingredient.id = recipe_has_ingredient.ingredientID
                                        JOIN ingredient_has_allergen ON ingredient.id = ingredient_has_allergen.ingredientID
                                        JOIN allergen ON allergen.id = ingredient_has_allergen.allergenID
                                    WHERE allergen.id = @allergenID;

                                    SELECT recipe.id, recipe.`Name`, recipe.Instructions, 
		                                recipe.cooktime, recipe.nutritionID, recipe.ethnicOriginID, image.image
                                    FROM recipe
                                        JOIN image ON recipe.id = image.recipeID
                                    WHERE recipe.id NOT IN tempAllergicRecipes; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@allergenID", allergenID);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] image_byte = (byte[])reader["image"];
                            MemoryStream ms = new MemoryStream(image_byte);
                            Recipe recipe = new Recipe
                            {
                                RecipeId = Convert.ToInt32(reader["id"]),
                                RecipeName = reader["Name"].ToString(),
                                RecipeInstructions = reader["Instructions"].ToString(),
                                CookingTime = Convert.ToInt32(reader["cooktime"]),
                                NutritionId = Convert.ToInt32(reader["nutritionID"]),
                                EthnicId = Convert.ToInt32(reader["ethnicOriginID"]),
                                RecipeImage = Image.FromStream(ms)
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
        public List<Recipe> GetSearchRecipe(string userSearch)
        {
            
            List<Recipe> recipes = new List<Recipe>();
            string selectStatement = "SELECT r.id, r.`Name`, r.Instructions, " +
                "r.cooktime, r.nutritionID, r.ethnicOriginID, i.image FROM recipe r JOIN image i " +
                "ON r.ID = i.recipeID where r.Name LIKE '%'|| @UserSearch ||'%'";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@UserSearch", userSearch);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Set up byte array and stream to convert BLOB image from db into something readable and can be displayed
                            byte[] image_byte = (byte[])reader["image"];
                            MemoryStream ms = new MemoryStream(image_byte);
                            Recipe recipe = new Recipe
                            {
                                RecipeId = Convert.ToInt32(reader["id"]),
                                RecipeName = reader["Name"].ToString(),
                                RecipeInstructions = reader["Instructions"].ToString(),
                                CookingTime = Convert.ToInt32(reader["cooktime"]),
                                NutritionId = Convert.ToInt32(reader["nutritionID"]),
                                EthnicId = Convert.ToInt32(reader["ethnicOriginID"]),
                                RecipeImage = Image.FromStream(ms)
                            };

                            recipes.Add(recipe);
                        }
                    }
                }
            }

            return recipes;
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
