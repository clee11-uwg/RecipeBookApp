﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace RecipeAppTestProject.Model
{
    /// <summary>
    /// Test class to test the KitchenWare Model class
    /// </summary>
    [TestClass]
    public class KitchenWareTests
    {
        /// <summary>
        /// Test Method to create get the Recipes KitchenWare
        /// </summary>
        [TestMethod]
        public void TestGetKitchenWareMethod()
        {
            List<Kitchenware> kicthenList = new List<Kitchenware>();
            Kitchenware kitchen = new Kitchenware
            {
                KitchenwareId=1,
                KitchenwareDetails= "Kitchen knives"
            };
            Kitchenware kitchen2 = new Kitchenware
            {
                KitchenwareId = 2,
                KitchenwareDetails = "Corkscrew"
            };

            kicthenList.Add(kitchen);
            kicthenList.Add(kitchen2);

            Assert.AreEqual(2, kicthenList.Count);
        }


        /// <summary>
        /// Test Method to create the Recipe KitchenWare
        /// </summary>

        [TestMethod]
        public void TestCreateKitchenWareMethod()
        {
            List<Kitchenware> kicthenList = new List<Kitchenware>();
            Kitchenware kitchen = new Kitchenware
            {
                KitchenwareId = 1,
                KitchenwareDetails = "Kitchen knives"
            };
            Kitchenware kitchen2 = new Kitchenware
            {
                KitchenwareId = 2,
                KitchenwareDetails = "Corkscrew"
            };

            kicthenList.Add(kitchen);
            kicthenList.Add(kitchen2);
            Assert.AreEqual("Kitchen knives", kicthenList[0].KitchenwareDetails);
        }


        /// <summary>
        /// Test Method to delete the Recipe KitchenWare
        /// </summary>

        [TestMethod]
        public void TestDeleteRecipeKitchenWareMethod()
        {
            List<Kitchenware> kicthenList = new List<Kitchenware>();
            Kitchenware kitchen = new Kitchenware
            {
                KitchenwareId = 1,
                KitchenwareDetails = "Kitchen knives"
            };
            Kitchenware kitchen2 = new Kitchenware
            {
                KitchenwareId = 2,
                KitchenwareDetails = "Corkscrew"
            };

            kicthenList.Add(kitchen);
            kicthenList.Add(kitchen2);
            kicthenList.RemoveAt(0);
            Assert.AreEqual("Corkscrew", kicthenList[0].KitchenwareDetails);
      
        }

        /// <summary>
        /// Test Method to update the Recipe KitchenWare
        /// </summary>

        [TestMethod]
        public void TestUpdateRecipeKitchenWareMethod()
        {
            List<Kitchenware> kicthenList = new List<Kitchenware>();
            Kitchenware kitchen = new Kitchenware
            {
                KitchenwareId = 1,
                KitchenwareDetails = "Kitchen knives"
            };
            Kitchenware kitchen2 = new Kitchenware
            {
                KitchenwareId = 2,
                KitchenwareDetails = "Corkscrew"
            };

            kicthenList.Add(kitchen);
            kicthenList.Add(kitchen2);
            kicthenList[0].KitchenwareDetails = "Electric mixer";
            Assert.AreEqual("Electric mixer", kicthenList[0].KitchenwareDetails);
        }
    }
}
