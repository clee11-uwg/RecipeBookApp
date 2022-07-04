using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RecipeBookApp.DAL;
using RecipeBookApp.Model;

namespace RecipeAppTestProject.DAL
{
    /// <summary>
    /// Tests the Type of Meal DAL
    /// </summary>
    [TestClass]
    public class TestTypeOfMealDAL
    {
        /**
        /// <summary>
        /// Tests GetMealTypes
        /// </summary>
        [TestMethod]
        public void TestGetMealTypes()
        {
            List<MealType> expectedMeals = new List<MealType>();
            MealType meal = new MealType
            {
                mealTypeID = 1,
                type = "Breakfast"
            };
            expectedMeals.Add(meal);

            Mock<TypeOfMealDAL> mock = new Mock<TypeOfMealDAL>();
            mock.Setup(x => x.GetMealTypes()).Returns(expectedMeals);

            TypeOfMealDAL actual = new TypeOfMealDAL();
            List<MealType> actualMeals = actual.GetMealTypes();
            mock.VerifyAll();
            //Assert.AreSame(expectedMeals, actualMeals);
        }
        */
    }
}
