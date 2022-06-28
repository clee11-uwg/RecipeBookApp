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

    }
}
