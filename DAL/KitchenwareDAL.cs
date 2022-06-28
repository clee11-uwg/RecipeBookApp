using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Kitchenware table.
    /// </summary>
    public class KitchenwareDAL
    {

        /// <summary>
        /// This method to get the list of Kitchenware avilable in the recipe database
        /// </summary>
        /// <returns>List of all kitchenware known to the database</returns>
        public List<Kitchenware> GetKitchenwares()
        {
            List<Kitchenware> cookwareList = new List<Kitchenware>();
            string selectStatement = "SELECT kitchenware.id, kitchenware.Kitchenware  FROM kitchenware; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kitchenware kitchen = new Kitchenware
                            {
                                KitchenwareId = Convert.ToInt32(reader["id"]),
                                KitchenwareDetails = reader["Kitchenware"].ToString(),
                            };

                            cookwareList.Add(kitchen);
                        }
                    }
                }
            }

            return cookwareList;
        }

        /// <summary>
        /// Finds all kitchenware needed to cook said recipe
        /// <param name="recipeID">Id of recipe</param>
        /// <returns>Kitchenware associated with recipe</returns>
        public List<Kitchenware> GetKitchenware(int recipeID)
        {
            List<Kitchenware> cookwareList = new List<Kitchenware>();
            string selectStatement = @"SELECT kitchenware.id, kitchenware.kitchenware
                                     FROM recipe JOIN recipe_uses_kitchenware ON recipe.id = recipe_uses_kitchenware.recipeID
                                         JOIN kitchenware ON kitchenware.id = recipe_uses_kitchenware.kitchenwareID
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
                            Kitchenware kitchen = new Kitchenware
                            {
                                KitchenwareId = Convert.ToInt32(reader["id"]),
                                KitchenwareDetails = reader["Kitchenware"].ToString(),
                            };

                            cookwareList.Add(kitchen);

                        }
                    }
                }
            }
            return cookwareList;
        }
    }
}
