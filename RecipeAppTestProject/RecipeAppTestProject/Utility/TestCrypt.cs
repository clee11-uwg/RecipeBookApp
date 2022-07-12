using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBookApp.Utility;
using System;

namespace RecipeAppTestProject.Utility
{
    /// <summary>
    /// Unit testing of cryptography utility functions
    /// </summary>
    [TestClass]
    public class TestCrypt
    {
        /// <summary>
        /// Tests that the given SHA-256 cryptographic function works for some known values
        /// </summary>
        [TestMethod]
        public void TestSHA256MethodDoesWorkForSomeKnownValues()
        {
            Assert.AreEqual(Crypt.SHA256_hash("password"), "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8");
            Assert.AreEqual(Crypt.SHA256_hash("test"), "9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08");
            Assert.AreEqual(Crypt.SHA256_hash("lol"), "07123e1f482356c415f684407a3b8723e10b2cbbc0b8fcd6282c49d37c9c1abc");
            Assert.AreEqual(Crypt.SHA256_hash("supercalifragilisticexpialidocious"), "c1111e162eb6d424f42b1b970b98780963ee494bac8ae1f3ad2ef42f426ab3cc");
        }
    }
}
