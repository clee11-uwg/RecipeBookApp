using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Type Of Meal table.
    /// </summary>
    public class TypeOfMealDAL
    {

        /// <summary>
        /// This method to get the list of Types of Meals avilable in the recipe database
        /// </summary>
        /// <returns>List of all types of meals known to the database</returns>
        public List<MealType> GetMealTypes()
        {
            List<MealType> mealTypesList = new List<MealType>();
            string selectStatement = @"	SELECT type_of_meal.id, type_of_meal.Type
	                                    FROM type_of_meal; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MealType typeOfMeal = new MealType
                            {
                                mealTypeID = Convert.ToInt32(reader["id"]),
                                type = reader["Type"].ToString(),
                            };

                            mealTypesList.Add(typeOfMeal);
                        }
                    }
                }
            }

            return mealTypesList;
        }

        /// <summary>
        /// Finds all meal types of said recipe
        /// <param name="recipeID">Id of recipe</param>
        /// <returns>Meal types of said recipe</returns>
        public List<MealType> GetMealTypes(int recipeID)
        {
            List<MealType> mealTypesList = new List<MealType>();
            string selectStatement = @"SELECT kitchenware.id, kitchenware.kitchenware
                                        FROM recipe
		                                    JOIN recipe_is_a_type_of_meal ON recipe_is_a_type_of_meal.recipeID = recipe.id
		                                    JOIN type_of_meal ON recipe_is_a_type_of_meal.typeOfMealID = type_of_meal.id
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
                            MealType typeOfMeal = new MealType
                            {
                                mealTypeID = Convert.ToInt32(reader["id"]),
                                type = reader["Type"].ToString(),
                            };

                            mealTypesList.Add(typeOfMeal);
                        }
                    }
                }
                return mealTypesList;
            }
        }
    }
}