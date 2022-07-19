using System;
using System.Collections.Generic;
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
        public  List<Recipe> GetRecipes()
        {
            //string workingDirectory = Environment.CurrentDirectory;
            //string path = Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"Data\", "sampleimage.jpg");
            List<Recipe> recipes = new List<Recipe>();
            string selectStatement = @"SELECT r.id, r.`Name`, r.Instructions,
                                            r.cooktime, r.nutritionID, r.ethnicOriginID, r.userWhoCreated, i.image 
                                        FROM recipe r 
                                            JOIN image i ON r.ID = i.recipeID;";
                

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
                                UserWhoCreated = reader["userWhoCreated"].ToString(),
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
        /// <param name="recipeID">ID of the recipe</param>
        /// <returns>The recipe of the given id</returns>
        public Recipe GetRecipe(int recipeID)
        {
            Recipe recipe = new Recipe();
            string selectStatement = @"SELECT recipe.id, recipe.`Name`, recipe.Instructions, recipe.cooktime, 
                                        recipe.nutritionID, recipe.ethnicOriginID, recipe.userWhoCreated, image.image
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
                                recipe.UserWhoCreated = reader["userWhoCreated"].ToString();
                                recipe.RecipeImage = Image.FromStream(ms);
                            };
                        }
                    }
                }
            }

            return recipe;
        }

        /// <summary>
        /// This method to get the recipe based on the  search ID
        /// </summary>
        /// <param name="userSearch">Search string to find recipes by</param>
        /// <returns></returns>
        public List<Recipe> GetSearchRecipe(string userSearch)
        {
            
            List<Recipe> recipes = new List<Recipe>();
            string selectStatement = @"SELECT r.id, r.`Name`, r.Instructions,
                                            r.cooktime, r.nutritionID, r.ethnicOriginID, r.userWhoCreated, i.image 
                                        FROM recipe r 
                                            JOIN image i ON r.ID = i.recipeID 
                                        WHERE r.Name LIKE '%'|| @UserSearch ||'%'";

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
                                UserWhoCreated = reader["userWhoCreated"].ToString(),
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
        /// Returns list of filtered recipes
        /// </summary>
        /// <param name="allergens">Undesired allergens</param>
        /// <param name="ethnicities">Undesired ethnicities</param>
        /// <param name="foodTypes">Undesired types of food</param>
        /// <param name="ingredients">Undesired ingredients</param>
        /// <param name="kitchenware">Undesired kitchenware</param>
        /// <param name="mealTypes">Undesired types of meal</param>
        /// <param name="nutrition">Undesired nutrition</param>
        /// <returns>List of recipes</returns>
        public List<Recipe> FilterRecipes(int[] allergens, int[] ethnicities, int[] foodTypes,
            int[] ingredients, int[] kitchenware, int[] mealTypes, int[] nutrition)
        {
            Console.WriteLine("Dispaly array + " + allergens);
          
            List<Recipe> recipes = new List<Recipe>();
            string selectStatement = @"DROP TABLE IF EXISTS tempFilterAllergen;
                                    CREATE TEMPORARY TABLE tempFilterAllergen AS
                                        SELECT recipe.id AS `id`
                                        FROM recipe
		                                    JOIN recipe_has_ingredient ON recipe.id = recipe_has_ingredient.recipeID
			                                    JOIN ingredient ON ingredient.id = recipe_has_ingredient.ingredientID
		                                    JOIN ingredient_has_allergen ON ingredient.id = ingredient_has_allergen.ingredientID
			                                    JOIN allergen ON allergen.id = ingredient_has_allergen.allergenID
	                                    WHERE allergen.id IN (@allergens);

                                    DROP TABLE IF EXISTS tempFilterEthnic;
                                    CREATE TEMPORARY TABLE tempFilterEthnic AS
                                        SELECT recipe.id AS `id`
                                        FROM recipe
		                                    JOIN ethnic_origin ON recipe.ethnicOriginID = ethnic_origin.id
	                                    WHERE ethnic_origin.id NOT IN (@ethnicities);

                                    DROP TABLE IF EXISTS tempFilterTypeOfFood;
                                    CREATE TEMPORARY TABLE tempFilterTypeOfFood AS
                                        SELECT recipe.id AS `id`
                                        FROM recipe
		                                    JOIN recipe_has_ingredient ON recipe_has_ingredient.recipeID = recipe.id
		                                    JOIN ingredient ON recipe_has_ingredient.ingredientID = ingredient.id
		                                    JOIN type_of_food ON type_of_food.id = ingredient.typeOfFoodID
	                                    WHERE type_of_food.id NOT IN (@typesOfFood);

                                    DROP TABLE IF EXISTS tempFilterIngredient;
                                    CREATE TEMPORARY TABLE tempFilterIngredient AS
                                        SELECT recipe.id AS `id`
                                        FROM recipe
		                                    JOIN recipe_has_ingredient ON recipe_has_ingredient.recipeID = recipe.id
		                                    JOIN ingredient ON recipe_has_ingredient.ingredientID = ingredient.id
	                                    WHERE ingredient.id NOT IN (@ingredients);

                                    DROP TABLE IF EXISTS tempFilterKitchenware;
                                    CREATE TEMPORARY TABLE tempFilterKitchenware AS
                                        SELECT recipe.id AS `id`
                                        FROM recipe
		                                    JOIN recipe_uses_kitchenware ON recipe_uses_kitchenware.recipeID = recipe.id
		                                    JOIN kitchenware ON recipe_uses_kitchenware.kitchenwareID = kitchenware.id
	                                    WHERE kitchenware.id NOT IN (@kitchenware);

                                    DROP TABLE IF EXISTS tempFilterTypesOfMeal;
                                    CREATE TEMPORARY TABLE tempFilterTypesOfMeal AS
                                        SELECT recipe.id AS `id`
                                        FROM recipe
		                                    JOIN recipe_is_a_type_of_meal ON recipe_is_a_type_of_meal.recipeID = recipe.id
		                                    JOIN type_of_meal ON recipe_is_a_type_of_meal.typeOfMealID = type_of_meal.id
	                                    WHERE type_of_meal.id NOT IN (@typesOfMeal);

                                    DROP TABLE IF EXISTS tempFilterNutrition;
                                    CREATE TEMPORARY TABLE tempFilterNutrition AS
                                        SELECT recipe.id AS `id`
                                        FROM recipe
		                                    JOIN nutrition ON recipe.nutritionID = nutrition.id
	                                    WHERE nutrition.id IN (@nutrition);

                                    SELECT recipe.id, recipe.`Name`, recipe.Instructions, 
	                                    recipe.cooktime, recipe.nutritionID, recipe.ethnicOriginID, recipe.userWhoCreated, image.image
                                    FROM recipe
                                        JOIN image on recipe.id = image.recipeID
                                    WHERE recipe.id NOT IN tempFilterAllergen
	                                    AND recipe.id IN tempFilterEthnic
	                                    AND recipe.id IN tempFilterTypeOfFood
	                                    AND recipe.id IN tempFilterIngredient
	                                    AND recipe.id IN tempFilterKitchenware
	                                    AND recipe.id IN tempFilterTypesOfMeal
	                                    AND recipe.id NOT IN tempFilterNutrition;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@allergens", allergens[0]);
                    selectCommand.Parameters.AddWithValue("@ethnicities", ethnicities[0]);
                    selectCommand.Parameters.AddWithValue("@typesOfFood", foodTypes[0]);
                    selectCommand.Parameters.AddWithValue("@ingredients", ingredients[0]);
                    selectCommand.Parameters.AddWithValue("@kitchenware", kitchenware[0]);
                    selectCommand.Parameters.AddWithValue("@typesOfMeal", mealTypes[0]);
                    selectCommand.Parameters.AddWithValue("@nutrition", nutrition[0]);
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
                                UserWhoCreated = reader["userWhoCreated"].ToString(),
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
        /// Returns a User's favorite recipes
        /// </summary>
        /// <param name="userID">ID of the user</param>
        /// <returns>List of favorite recipes</returns>
        public List<Recipe> GetFavoriteRecipes(int userID)
        {
            List<Recipe> favorites = new List<Recipe>();
            string selectStatement = @"SELECT recipe.id, recipe.`Name`, recipe.Instructions, 
	                                        recipe.cooktime, recipe.nutritionID, recipe.ethnicOriginID, 
	                                        recipe.userWhoCreated, image.image
                                        FROM recipe
	                                        JOIN image on recipe.id = image.recipeID
	                                        JOIN User_has_favorite_Recipes ON recipe.id = User_has_favorite_Recipes.recipeID
	                                        JOIN User ON User.id = User_has_favorite_Recipes.userID
                                        WHERE user.id = @userID;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userID", userID);
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
                                UserWhoCreated = reader["userWhoCreated"].ToString(),
                                RecipeImage = Image.FromStream(ms)
                            };
                            favorites.Add(recipe);
                        }
                    }
                }
            }
            return favorites;
        }

        /// <summary>
        /// Inserts the recipe into the database
        /// </summary>
        /// <param name="recipe">Recipe to add</param>
        /// <returns>Id of the Recipe added, -1 if nothing added</returns>
        public int AddRecipe(Recipe recipe)
        {
            int id = -1;
            string addRecipeStatement = @"INSERT INTO recipe (Name, Instructions, cooktime, nutritionID, 
                                            ethnicOriginID, userWhoCreated)
                                        VALUES(@name, @instructions, @cooktime, @nutritionID, 
                                            @ethnicOriginID, @userWhoCreated); ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(addRecipeStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@name", recipe.RecipeName);
                    selectCommand.Parameters.AddWithValue("@instructions", recipe.RecipeInstructions);
                    selectCommand.Parameters.AddWithValue("@cooktime", recipe.CookingTime);
                    selectCommand.Parameters.AddWithValue("@nutritionID", recipe.NutritionId);
                    selectCommand.Parameters.AddWithValue("@ethnicOriginID", recipe.EthnicId);
                    selectCommand.Parameters.AddWithValue("@userWhoCreated", recipe.UserWhoCreated);

                    id = Convert.ToInt32(selectCommand.ExecuteScalar());
                    
                }
            }
            return id;
        }

        /// <summary>
        /// Deletes the recipe from the database
        /// </summary>
        /// <param name="recipe">Recipe to delete</param>
        /// <returns>Whether or not the recipe was deleted</returns>
        public bool DeleteRecipe(Recipe recipe)
        {
            int result = -1;
            string addRecipeStatement = @"DELETE FROM recipe
                                            WHERE id = @id;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(addRecipeStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@id", recipe.RecipeId);

                    result = selectCommand.ExecuteNonQuery();
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Updates the Recipe to the database
        /// </summary>
        /// <param name="nutrition">Recipe to update</param>
        /// <returns>Whether or not the recipe updated</returns>
        public bool UpdateRecipe(Recipe recipe)
        {
            int result = -1;
            string selectStatement = @"UPDATE recipe 
                                        SET Name = @name, 
	                                        Instructions = @instructions, 
	                                        cooktime = @cooktime, 
	                                        nutritionID = @nutritionID, 
	                                        ethnicOriginID = @ethnicOriginID, 
	                                        userWhoCreated = @userWhoCreated
                                        WHERE id = @id;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@name", recipe.RecipeName);
                    selectCommand.Parameters.AddWithValue("@instructions", recipe.RecipeInstructions);
                    selectCommand.Parameters.AddWithValue("@cooktime", recipe.CookingTime);
                    selectCommand.Parameters.AddWithValue("@nutritionID", recipe.NutritionId);
                    selectCommand.Parameters.AddWithValue("@ethnicOriginID", recipe.EthnicId);
                    selectCommand.Parameters.AddWithValue("@userWhoCreated", recipe.UserWhoCreated);
                    selectCommand.Parameters.AddWithValue("@id", recipe.RecipeId);

                    result = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Inserts the recipe image into the database
        /// </summary>
        /// <param name="recipe">Recipe whose image to add</param>
        /// <returns>If the insertion worked</returns>
        public bool AddImage(Recipe recipe)
        {
            int result = -1;
            string addRecipeStatement = @"INSERT INTO image (recipeID, image)
                                            VALUES (@recipeID, @image); ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(addRecipeStatement, connection))
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        selectCommand.Parameters.AddWithValue("@recipeID", recipe.RecipeId);
                        recipe.RecipeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                        byte[] data = stream.ToArray();
                        selectCommand.Parameters.AddWithValue("@image", data);
                        result = Convert.ToInt32(selectCommand.ExecuteScalar());

                    }
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Deletes the recipe image from the database
        /// </summary>
        /// <param name="id">Id of recipe to delete</param>
        /// <returns>Whether or not the recipe was deleted</returns>
        public bool DeleteImage(int id)
        {
            int result = -1;
            string addRecipeStatement = @"DELETE FROM image
                                            WHERE recipeID = @id;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(addRecipeStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@id", id);

                    result = selectCommand.ExecuteNonQuery();
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Updates the Recipe image in the database
        /// </summary>
        /// <param name="nutrition">Recipe to update</param>
        /// <returns>Whether or not the recipe image updated</returns>
        public bool UpdateImage(Recipe recipe)
        {
            int result = -1;
            string selectStatement = @"UPDATE image
                                        SET image = @image
                                        WHERE recipeID = @id;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        selectCommand.Parameters.AddWithValue("@id", recipe.RecipeId);
                        recipe.RecipeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                        byte[] data = stream.ToArray();
                        selectCommand.Parameters.AddWithValue("@image", data);

                        result = Convert.ToInt32(selectCommand.ExecuteScalar());
                    }
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Adds a new row to the recipe_uses_kitchenware table
        /// <param name="recipeID">Id of the Recipe</param>
        /// <param name="kitchenwareID">Id of the Kitchenware</param>
        /// <returns>If the database was updated or not</returns>
        public bool AddRecipeUsesKitchenware(int recipeID, int kitchenwareID)
        {
            int result = -1;
            string selectStatement = @"INSERT INTO recipe_uses_kitchenware (recipeID, kitchenwareID)
                                        VALUES (@recipeID, @kitchenwareID);";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);
                    selectCommand.Parameters.AddWithValue("@kitchenwareID", kitchenwareID);

                    id = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Deletes the row from recipe_has_kitchenware table
        /// <param name="recipeID">Id of the Recipe</param>
        /// <returns>If the database was updated or not</returns>
        public bool DeleteRecipeUsesKitchenware(int recipeID)
        {
            int result = -1;
            string selectStatement = @"DELETE FROM recipe_uses_kitchenware
                                        WHERE recipeID = @recipeID;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);

                    result = selectCommand.ExecuteNonQuery();
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Adds a new row to the recipe_is_a_type_of_meal table
        /// <param name="recipeID">Id of the Recipe</param>
        /// <param name="typeOfMealID">Id of the Type of Meal</param>
        /// <returns>If the database was updated or not</returns>
        public bool AddRecipeIsATypeOfMeal(int recipeID, int typeOfMealID)
        {
            int result = -1;
            string selectStatement = @"INSERT INTO recipe_is_a_type_of_meal (recipeID, typeOfMealID)
                                        VALUES (@recipeID, @typeOfMealID);";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);
                    selectCommand.Parameters.AddWithValue("@typeOfMealID", typeOfMealID);

                    id = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Deletes the row from recipe_is_a_type_of_meal table
        /// <param name="recipeID">Id of the Recipe</param>
        /// <returns>If the database was updated or not</returns>
        public bool DeleteRecipeIsATypeOfMeal(int recipeID)
        {
            int result = -1;
            string selectStatement = @"DELETE FROM recipe_is_a_type_of_meal
                                        WHERE recipeID = @recipeID;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);

                    result = selectCommand.ExecuteNonQuery();
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Adds a new row to the recipe_has_ingredient table
        /// <param name="recipeID">Id of the Recipe</param>
        /// <param name="ingredientID">Id of the Ingredient</param>
        /// <returns>If the database was updated or not</returns>
        public bool AddRecipeHasIngredient(int recipeID, int ingredientID, string amount)
        {
            int result = -1;
            string selectStatement = @"INSERT INTO recipe_has_ingredient (recipeID, ingredientID, amount)
                                        VALUES (@recipeID, @ingredientID, @amount);";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);
                    selectCommand.Parameters.AddWithValue("@ingredientID", ingredientID);
                    selectCommand.Parameters.AddWithValue("@amount", amount);

                    id = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Deletes the row from recipe_has_ingredient table
        /// <param name="recipeID">Id of the Recipe</param>
        /// <returns>If the database was updated or not</returns>
        public bool DeleteRecipeHasIngredient(int recipeID)
        {
            int result = -1;
            string selectStatement = @"DELETE FROM recipe_has_ingredient
                                        WHERE recipeID = @recipeID;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);

                    result = selectCommand.ExecuteNonQuery();
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Updates a row in recipe_has_ingredient table
        /// <param name="recipeID">Id of the Recipe</param>
        /// <param name="ingredientID">Id of the Ingredient</param>
        /// <returns>If the database was updated or not</returns>
        public bool UpdateAmountInRecipeHasIngredient(int recipeID, int ingredientID, string amount)
        {
            int result = -1;
            string selectStatement = @"UPDATE recipe_has_ingredient
                                        SET amount = @amount
                                        WHERE recipeID = @recipeID AND ingredientID = @ingredientID;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);
                    selectCommand.Parameters.AddWithValue("@ingredientID", ingredientID);
                    selectCommand.Parameters.AddWithValue("@amount", amount);

                    result = selectCommand.ExecuteNonQuery();
                }
            }
            if (result < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
