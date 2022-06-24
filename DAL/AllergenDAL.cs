using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using RecipeBookApp.Model;

namespace RecipeBookApp.DAL
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the Recipe application
    /// and the AllergenDAL.
    /// </summary>
    public  class AllergenDAL
    {
        /// <summary>
        /// This method to get the list of Allergen avilable in the recipe database
        /// </summary>
        /// <returns></returns>
        public List<Allergen> GetAllergens()
        {
            List<Allergen> allergenList  = new List<Allergen>();
            string selectStatement = "SELECT allergen.id, allergen.allergen FROM allergen; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
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
        /// This method to get the allergen details of a recipe
        /// </summary>
        /// <returns></returns>
        public Allergen GetRecipeAllergen(int recipeID)
        {
            Allergen allergen = null;
            string selectStatement = "SELECT allergen.id, allergen.allergen    FROM recipe " +
       " JOIN recipe_has_ingredient ON recipe.id = recipe_has_ingredient.recipeID " +
        "JOIN ingredient ON ingredient.id = recipe_has_ingredient.ingredientID "+
        "JOIN ingredient_has_allergen ON ingredient.id = ingredient_has_allergen.ingredientID " +
       " JOIN allergen ON allergen.id = ingredient_has_allergen.allergenID WHERE recipe.id = @recipeID; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectStatement, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {

                         allergen = new Allergen
                        {
                            AllergenId = Convert.ToInt32(reader["id"]),
                            AllergenDetails = reader["allergen"].ToString()
                        };


                    }
                }
            }

            return allergen;
        }

        /// <summary>
        /// This method to get the list of Allergen avilable in the recipe database
        /// </summary>
        /// <returns></returns>
        public List<Allergen> GetAllergensOfIngredient(int ingredientID)
        {
            List<Allergen> allergenList = new List<Allergen>();
            string selectStatement = "	SELECT allergen.id, allergen.allergen" +
    "FROM ingredient" +
        "JOIN ingredient_has_allergen ON ingredient.id = ingredient_has_allergen.ingredientID" +
        "JOIN allergen ON allergen.id = ingredient_has_allergen.allergenID" +
    "WHERE ingredient.id = @ingredientID; ";

            using (SQLiteConnection connection = DBConnection.GetConnection())
            {
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




    }
}
