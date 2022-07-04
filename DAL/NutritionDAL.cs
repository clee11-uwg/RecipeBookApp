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
                                        JOIN recipe_has_ingredient ON recipe_has_ingredient.recipeID = recipe.id
                                        JOIN ingredient ON recipe_has_ingredient.ingredientID = ingredient.id
                                        JOIN type_of_food ON ingredient.typeOfFoodID = type_of_food.id
                                         JOIN nutrition ON ingredient.nutritionID = nutrition.id
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
    }

}
