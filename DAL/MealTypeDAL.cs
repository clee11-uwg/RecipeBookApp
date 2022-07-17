using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using RecipeBookApp.Model;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Meal Type table.
    /// </summary>
    public class MealTypeDAL
    {
        /// <summary>
        /// This method to get the list of all mealtype known to the recipe database
        /// </summary>
        /// <returns>List of Allergens known to the recipe database</returns>
        public List<MealType> GetMealTypes()
        {
            List<MealType> mealList  = new List<MealType>();
            string selectStatement = "SELECT meal.id, meal.type FROM type_of_meal meal; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MealType meal = new MealType
                            {
                                mealTypeID = Convert.ToInt32(reader["id"]),
                                type = reader["type"].ToString()
                            };

                            mealList.Add(meal);
                        }
                    }
                }
            }

            return mealList;
        }


        /// <summary>
        /// This method to get the list of all mealtype known to the recipe database
        /// </summary>
        /// <param name="recipeID">Id of recipe</param>
        /// <returns>List of Allergens known to the recipe database</returns>
        public List<MealType> GetMealTypes(int recipeID)
        {
            List<MealType> mealList = new List<MealType>();
            string selectStatement = @"SELECT type_of_meal.id, type_of_meal.type 
                                        FROM type_of_meal
                                            JOIN recipe_is_a_type_of_meal ON type_of_meal.id = recipe_is_a_type_of_meal.typeOfMealID
                                            JOIN recipe ON recipe.id = recipe_is_a_type_of_meal.recipeID
                                        WHERE recipe.id = @recipeID; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@recipeID", recipeID);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MealType meal = new MealType
                            {
                                mealTypeID = Convert.ToInt32(reader["id"]),
                                type = reader["type"].ToString()
                            };

                            mealList.Add(meal);
                        }
                    }
                }
            }

            return mealList;
        }

    }
}
