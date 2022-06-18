
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RecipeBookApp.DAL
{
    public class IngredientsDAL
    {


        /// <summary>
        /// This method to get the Ingredients
        /// </summary>
        /// <returns></returns>
        public List<Ingredient> GetIngredients()
        {
            //Ingredient ingredient = null;
            List<Ingredient> ingredientDetails = new List<Ingredient>();
            string selectStatement = "SELECT ingredient.id, ingredient.ingredient,ingredient.typeOfFoodID, " +
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
        /// <returns>Ingredients </returns>
        public Ingredient GetIngredient(int recipeID)
        {
            Ingredient ingredient = null;
            string selectStatement = "SELECT ingredient.id, ingredient.Ingredient, type_of_food.`Type`, nutrition.stub " +
                     " FROM recipe JOIN recipe_has_ingredient ON recipe_has_ingredient.recipeID = recipe.id " +
                 " JOIN ingredient ON recipe_has_ingredient.ingredientID = ingredient.id " +
                 " JOIN type_of_food ON ingredient.typeOfFoodID = type_of_food.id " +
                "JOIN nutrition ON ingredient.nutritionID = nutrition.id " +
                " WHERE recipe.id = recipeID; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        ingredient = new Ingredient
                        {
                            IngredientId = Convert.ToInt32(reader["id"]),
                            IngredientName = reader["ingredient"].ToString(),
                            FoodId = Convert.ToInt32(reader["typeOfFoodID"]),
                            NutritionId = Convert.ToInt32(reader["nutritionID"])

                        };


                    }
                }
            }

            return ingredient;
        }


    }
}
