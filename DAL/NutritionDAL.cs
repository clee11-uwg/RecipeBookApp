using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RecipeBookApp.DAL
{
    
    /// <summary>
    /// Runs the queries against the recipe db related to nutritional dats
    /// </summary>
    public class NutritionDAL
    {

        /// <summary>
        /// This method to get the list of Kitchenware avilable in the recipe database
        /// </summary>
        /// <returns>List of all nutritional data known to the database</returns>
        public List<Nutrition> GetNutritions(string sort)
        {
            List<Nutrition> nutritionList = new List<Nutrition>();
            string selectStatement = @"SELECT nutrition.id, nutrition.carbohydrate, nutrition.protein, nutrition.fat,
                                        nutrition.alcohol, nutrition.calories, nutrition.serving_size
                                    FROM nutrition
                                    ORDER BY @sort;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@sort", sort);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nutrition nutrition = new Nutrition
                            {
                                NutritionId = Convert.ToInt32(reader["id"]),
                                Carbohydrate = Convert.ToInt32(reader["carbohydrate"]),
                                Fat = Convert.ToInt32(reader["fat"]),
                                Protein = Convert.ToInt32(reader["protein"]),
                                Alcohol = Convert.ToInt32(reader["alcohol"]),
                                Calories = Convert.ToInt32(reader["calories"]),
                                ServingSize = reader["serving_size"].ToString()
                            };

                            nutritionList.Add(nutrition);
                        }
                    }
                }
            }

            return nutritionList;
        }

        /// <summary>
        /// This method to get the nutrition data based on the  search ID
        /// </summary>
        /// <param name="recipeID">ID of the recipe</param>
        /// <returns>Nutritional data of the given recipe</returns>
        public List<Nutrition> GetNutrition(int recipeID)
        {
            List<Nutrition> nutritionList = new List<Nutrition>();
            string selectStatement = @"SELECT nutrition.id, nutrition.carbohydrate, nutrition.protein, nutrition.fat,
	                                        nutrition.alcohol, nutrition.calories, nutrition.serving_size 
                                        FROM recipe  
	                                         JOIN nutrition ON recipe.nutritionID = nutrition.id
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
                            Nutrition nutrition = new Nutrition
                            {
                                NutritionId = Convert.ToInt32(reader["id"]),
                                Carbohydrate = Convert.ToInt32(reader["carbohydrate"]),
                                Fat = Convert.ToInt32(reader["fat"]),
                                Protein = Convert.ToInt32(reader["protein"]),
                                Alcohol = Convert.ToInt32(reader["alcohol"]),
                                Calories = Convert.ToInt32(reader["calories"]),
                                ServingSize = reader["serving_size"].ToString()
                            };

                            nutritionList.Add(nutrition);
                        }

                    }
                }
            }
            return nutritionList;
        }

        /// <summary>
        /// Adds the Nutrition to the database
        /// </summary>
        /// <param name="nutrition">Nutrition to add</param>
        /// <returns>Id of the nutrition added, -1 if nothing added</returns>
        public int AddNutrition(Nutrition nutrition)
        {
            int id = -1;
            string selectStatement = @"INSERT INTO nutrition (carbohydrate, fat, protein, alcohol, calories, serving_size)
                                    VALUES (@carbohydrate, @fat, @protein, @alcohol, @calories, @serving_size);";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@carbohydrate", nutrition.Carbohydrate);
                    selectCommand.Parameters.AddWithValue("@fat", nutrition.Fat);
                    selectCommand.Parameters.AddWithValue("@protein", nutrition.Protein);
                    selectCommand.Parameters.AddWithValue("@alcohol", nutrition.Alcohol);
                    selectCommand.Parameters.AddWithValue("@calories", nutrition.Calories);
                    selectCommand.Parameters.AddWithValue("@serving_size", nutrition.ServingSize);

                    connection.Open();
                    id = Convert.ToInt32(selectCommand.ExecuteScalar());
                    connection.Close();
                }
            }
            return id;
        }

        /// <summary>
        /// Deletes the Nutrition to the database
        /// </summary>
        /// <param name="id">Id of nutrition to delete</param>
        /// <returns>Whether or not the deletion was successful</returns>
        public bool DeleteNutrition(int id)
        {
            int result = -1;
            string selectStatement = @"DELETE FROM nutrition
                                    WHERE id = @id;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    result = selectCommand.ExecuteNonQuery();
                    connection.Close();
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
        /// Updates the Nutrition to the database
        /// </summary>
        /// <param name="nutrition">Nutrition to update</param>
        /// <returns>Whether or not the nutrition updated</returns>
        public bool UpdateNutrition(Nutrition nutrition)
        {
            int result = -1;
            string selectStatement = @"UPDATE nutrition 
                                        SET carbohydrate = @carbohydrate, 
	                                        fat = @fat, 
	                                        protein = @protein, 
	                                        alcohol = @alcohol, 
	                                        calories = @calories, 
	                                        serving_size = @serving_size
                                        WHERE id = @id;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@carbohydrate", nutrition.Carbohydrate);
                    selectCommand.Parameters.AddWithValue("@fat", nutrition.Fat);
                    selectCommand.Parameters.AddWithValue("@protein", nutrition.Protein);
                    selectCommand.Parameters.AddWithValue("@alcohol", nutrition.Alcohol);
                    selectCommand.Parameters.AddWithValue("@calories", nutrition.Calories);
                    selectCommand.Parameters.AddWithValue("@serving_size", nutrition.ServingSize);
                    selectCommand.Parameters.AddWithValue("@id", nutrition.NutritionId);

                    //connection.Open();
                    result = Convert.ToInt32(selectCommand.ExecuteScalar());
                    //connection.Close();
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
