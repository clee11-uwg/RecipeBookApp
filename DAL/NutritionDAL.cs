using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;


namespace RecipeBookApp.DAL
{
    
    
    /// <summary>
    /// This is 
    /// </summary>
    public class NutritionDAL
    {
        /// <summary>
        /// This method to get the list of Kitchenware avilable in the recipe database
        /// </summary>
        /// <returns>List of all nutritional data known to the database</returns>
        public List<Nutrition> GetNutritions()
        {
            List<Nutrition> nutritionList = new List<Nutrition>();
            string selectStatement = "SELECT nutrition.id, nutrition.Stub    FROM nutrition; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nutrition nutrition = new Nutrition
                            {
                                NutritionId = Convert.ToInt32(reader["id"]),
                                NutritionDetails = reader["Stub"].ToString(),
                            };

                            nutritionList.Add(nutrition);
                        }
                    }
                }
            }

            return nutritionList;
        }

        /// <summary>
        /// This method to get the nutrition based on the  search ID
        /// </summary>
        /// <param name="recipeID">ID of the recipe</param>
        /// <returns>Nutritional data of the given recipe</returns>
        public Nutrition GetNutrition(int recipeID)
        {
            Nutrition nutrition = null;
            string selectStatement = "SELECT ingredient.id, ingredient.Ingredient, type_of_food.`Type`," +
             "nutrition.stub FROM recipe  JOIN recipe_has_ingredient ON recipe_has_ingredient.recipeID = recipe.id " +
            "JOIN ingredient ON recipe_has_ingredient.ingredientID = ingredient.id " +
            "JOIN type_of_food ON ingredient.typeOfFoodID = type_of_food.id " +
             "JOIN nutrition ON ingredient.nutritionID = nutrition.id " +
            "WHERE recipe.id = recipeID;";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {

                         nutrition = new Nutrition
                        {
                            NutritionId = Convert.ToInt32(reader["id"]),
                            NutritionDetails = reader["Stub"].ToString(),
                        };

                    }
                }
            }
            return nutrition;
        }
    }



}
