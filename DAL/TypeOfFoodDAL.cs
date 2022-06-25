using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Type Of Food table.
    /// </summary>
    public class TypeOfFoodDAL
    {

        /// <summary>
        /// This method to get the list of Types of Foods avilable in the recipe database
        /// </summary>
        /// <returns>List of all types of foods known to the database</returns>
        public List<FoodType> GetFoodTypes()
        {
            List<FoodType> foodTypesList = new List<FoodType>();
            string selectStatement = @"	SELECT type_of_food.id, type_of_food.`Type`
                                        FROM type_of_food; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FoodType typeOfFood = new FoodType
                            {
                                FoodId = Convert.ToInt32(reader["id"]),
                                TypeOfFood = reader["Type"].ToString(),
                            };

                            foodTypesList.Add(typeOfFood);
                        }
                    }
                }
            }

            return foodTypesList;
        }

        /// <summary>
        /// Finds all meal types of said recipe
        /// <param name="recipeID">Id of recipe</param>
        /// <returns>Meal types of said recipe</returns>
        public List<FoodType> GetFoodTypes(int recipeID)
        {
            List<FoodType> foodTypesList = new List<FoodType>();
            string selectStatement = @"SELECT type_of_food.id, type_of_food.`Type`
                                        FROM recipe
			                                JOIN recipe_has_ingredient ON recipe_has_ingredient.recipeID = recipe.id
		                                    JOIN ingredient ON recipe_has_ingredient.ingredientID = ingredient.id
		                                    JOIN type_of_food ON type_of_food.id = ingredient.typeOfFoodID
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
                            FoodType typeOfFood = new FoodType
                            {
                                FoodId = Convert.ToInt32(reader["id"]),
                                TypeOfFood = reader["Type"].ToString(),
                            };

                            foodTypesList.Add(typeOfFood);
                        }
                    }
                }
                return foodTypesList;
            }
        }
    }
}