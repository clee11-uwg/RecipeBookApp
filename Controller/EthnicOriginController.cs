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
    }
}