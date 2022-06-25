﻿using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Ingredient table.
    /// </summary>
    public class IngredientsDAL
    {

        /// <summary>
        /// This method to get the Ingredients
        /// </summary>
        /// <returns>List of all ingredients known to the db</returns>
        public List<Ingredient> GetIngredients()
        {
            List<Ingredient> ingredientDetails = new List<Ingredient>();
            string selectStatement = "SELECT ingredient.id, ingredient.ingredient, ingredient.typeOfFoodID, " +
                "ingredient.nutritionID FROM ingredient; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Ingredient ingredient = new Ingredient
                            {
                                IngredientId = Convert.ToInt32(reader["id"]),
                                IngredientName = reader["ingredient"].ToString(),
                                FoodId = Convert.ToInt32(reader["typeOfFoodID"]),
                                NutritionId = Convert.ToInt32(reader["nutritionID"])

                            };
                            ingredientDetails.Add(ingredient);
                        }

                    }
                }
            }

            return ingredientDetails;
        }

        /// <summary>
        /// This method to get the Ingredients based on the recipe ID
        /// </summary>
        /// <returns>ID of recipe</returns>
        public List<Ingredient> GetIngredient(int recipeID)
        {
            List<Ingredient> ingredientDetails = new List<Ingredient>();
            string selectStatement = "SELECT ingredient.id, ingredient.Ingredient, ingredient.typeOfFoodID, ingredient.nutritionID " +
                     " FROM recipe JOIN recipe_has_ingredient ON recipe_has_ingredient.recipeID = recipe.id " +
                 " JOIN ingredient ON recipe_has_ingredient.ingredientID = ingredient.id " +
                " WHERE recipe.id = @recipeID; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Ingredient ingredient = new Ingredient
                            {
                                IngredientId = Convert.ToInt32(reader["id"]),
                                IngredientName = reader["ingredient"].ToString(),
                                FoodId = Convert.ToInt32(reader["typeOfFoodID"]),
                                NutritionId = Convert.ToInt32(reader["nutritionID"])

                            };
                            ingredientDetails.Add(ingredient);
                        }
                    }
                }
            }

            return ingredientDetails;
        }


    }
}
