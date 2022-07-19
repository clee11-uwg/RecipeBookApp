using System;
using System.Collections.Generic;
using System.Data.SQLite;
using RecipeBookApp.Model;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the  DB Allergen table.
    /// </summary>
    public class AllergenDAL
    {
        /// <summary>
        /// This method to get the list of all Allergens known to the recipe database
        /// </summary>
        /// <returns>List of Allergens known to the recipe database</returns>
        public List<Allergen> GetAllergens()
        {
            List<Allergen> allergenList = new List<Allergen>();
            string selectStatement = "SELECT allergen.id, allergen.allergen FROM allergen; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Allergen allergen = new Allergen
                            {
                                AllergenId = Convert.ToInt32(reader["id"]),
                                AllergenDetails = reader["allergen"].ToString()
                            };

                            allergenList.Add(allergen);
                        }
                    }
                }
            }

            return allergenList;
        }

        /// <summary>
        /// This method to get the list of allergens a recipe may contain
        /// </summary>
        /// <param name="recipeID">ID of the recipe</param>
        /// <returns>List of Allergens a recipe may contain</returns>
        public List<Allergen> GetRecipeAllergen(int recipeID)
        {
            List<Allergen> allergenList = new List<Allergen>();
            string selectStatement = @"SELECT allergen.id, allergen.allergen    
                                    FROM recipe
                                       JOIN recipe_has_ingredient ON recipe.id = recipe_has_ingredient.recipeID
                                        JOIN ingredient ON ingredient.id = recipe_has_ingredient.ingredientID
                                        JOIN ingredient_has_allergen ON ingredient.id = ingredient_has_allergen.ingredientID
                                       JOIN allergen ON allergen.id = ingredient_has_allergen.allergenID 
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
                            Allergen allergen = new Allergen
                            {
                                AllergenId = Convert.ToInt32(reader["id"]),
                                AllergenDetails = reader["allergen"].ToString()
                            };

                            allergenList.Add(allergen);

                        }
                    }
                }
            }
            return allergenList;
        }

        /// <summary>
        /// Returns Allergens of an Ingredient
        /// </summary>
        /// <param name="ingredientID">ID of the ingredient</param>
        /// <returns>List of Allergens of an Ingredient</returns>
        public List<Allergen> GetAllergensOfIngredient(int ingredientID)
        {
            List<Allergen> allergenList = new List<Allergen>();
            string selectStatement = @"SELECT allergen.id, allergen.allergen
                                        FROM ingredient
                                            JOIN ingredient_has_allergen ON ingredient.id = ingredient_has_allergen.ingredientID
                                            JOIN allergen ON allergen.id = ingredient_has_allergen.allergenID
                                        WHERE ingredient.id = @ingredientID; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    connection.Open();
                    selectCommand.Parameters.AddWithValue("@ingredientID", ingredientID);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Allergen allergen = new Allergen
                            {
                                AllergenId = Convert.ToInt32(reader["id"]),
                                AllergenDetails = reader["allergen"].ToString()
                            };

                            allergenList.Add(allergen);
                        }
                    }
                }
            }

            return allergenList;
        }
    }
}
