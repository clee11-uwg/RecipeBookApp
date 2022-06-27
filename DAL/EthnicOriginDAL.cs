using System;
using System.Collections.Generic;
using System.Data;
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
    }
}