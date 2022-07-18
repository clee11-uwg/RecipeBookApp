using System;
using System.Collections.Generic;
using System.Data.SQLite;
using RecipeBookApp.Model;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Ethnic Origin table.
    /// </summary>
    public class EthnicOriginDAL
    {
        /// <summary>
        /// This method to get the list of all Ethnic Origins known to the database
        /// </summary>
        /// <returns>List of Ethnic Origins known to the database</returns>
        public List<Ethnic> GetEthnicOrigins()
        {
            List<Ethnic> ethnicList = new List<Ethnic>();
            string selectStatement = "SELECT ethnic_origin.id, ethnic_origin.Ethnicity FROM ethnic_origin; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ethnic ethnic = new Ethnic
                            {
                                EthnicId = Convert.ToInt32(reader["id"]),
                                Ethnicity = reader["Ethnicity"].ToString()
                            };

                            ethnicList.Add(ethnic);
                        }
                    }
                }
            }

            return ethnicList;
        }

        /// <summary>
        /// Finds all ethnicities of the recipe
        /// <param name="recipeID">Id of recipe</param>
        /// <returns>Ethnicities associated with recipe</returns>
        public List<Ethnic> GetEthnicOrigin(int recipeID)
        {
            List<Ethnic> ethnicList = new List<Ethnic>();
            string selectStatement = @"SELECT ethnic_origin.id, ethnic_origin.Ethnicity 
                                        FROM ethnic_origin
	                                        JOIN recipe ON ethnic_origin.id = recipe.ethnicOriginID
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
                            Ethnic ethnic = new Ethnic
                            {
                                EthnicId = Convert.ToInt32(reader["id"]),
                                Ethnicity = reader["Ethnicity"].ToString()
                            };

                            ethnicList.Add(ethnic);
                        }
                    }
                }
            }
            return ethnicList;
        }
    }
}