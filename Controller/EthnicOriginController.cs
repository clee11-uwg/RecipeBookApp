using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBookApp.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the Recipe application
    /// and the EthnicOriginDAL. 
    /// </summary>
    public class EthnicOriginController
    {

        private readonly EthnicOriginDAL ethnicOriginDAL;
        /// <summary>
        /// Constructor for EthnicOriginController
        /// </summary>
        public EthnicOriginController()
        {
            this.ethnicOriginDAL = new EthnicOriginDAL();
        }

        /// <summary>
        /// Gets all Ethnic Origins known to the database
        /// </summary>
        /// <returns>List of all ethnic origins from database </returns>
        public List<Ethnic> GetEthnicOrigins()
        {
            return this.ethnicOriginDAL.GetEthnicOrigins();
        }

        /// <summary>
        /// Gets all Ethnic Origins associated with said recipe
        /// </summary>
        /// <param name="recipeID">ID of recipe</param>
        /// <returns>Ethnicities associated with said recipe</returns>
        public List<Ethnic> GetEthnicOrigin(int recipeID)
        {
            if (recipeID < 1)
            {
                throw new ArgumentOutOfRangeException("Recipe ID cannot be less than 1");
            }
            return this.ethnicOriginDAL.GetEthnicOrigin(recipeID);
        }
    }
}