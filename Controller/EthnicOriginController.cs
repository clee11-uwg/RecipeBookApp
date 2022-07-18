using RecipeBookApp.DAL;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;

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

        /// <see cref="EthnicOriginDAL.GetEthnicOrigins"/>
        public List<Ethnic> GetEthnicOrigins()
        {
            return this.ethnicOriginDAL.GetEthnicOrigins();
        }

        /// <see cref="EthnicOriginDAL.GetEthnicOrigin(int)"/>
        /// <exception cref="ArgumentOutOfRangeException">If recipeID is less than 1</exception>
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