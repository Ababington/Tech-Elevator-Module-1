using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]

    public class NonStartTest
    {
        [TestMethod]
        public void NonStartTestHappyPath()
        {
            //GetPartialString("Hello", "There") → "ellohere"
            //GetPartialString("java", "code") → "avaode"
            //GetPartialString("shotl", "java") → "hotlava"

            // Arrange - 
            NonStart nonStart = new NonStart();
            string inputOne = "Hello";
            string inputTwo = "There";
            string expected = "ellohere";
            string result;

            // Act
            result = nonStart.GetPartialString(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - 

            inputOne = "jTen";
            inputTwo = "tent";
            expected = "Tenent";

            // Act
            result = nonStart.GetPartialString(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NonStartTestException()
        {


            // Arrange - 
            NonStart nonStart = new NonStart();
            string inputOne = "";
            string inputTwo = "There";
            string expected = "here";
            string result;

            // Act
            result = nonStart.GetPartialString(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange
            inputOne = "";
            inputTwo = "";
            expected = "";

            // Act
            result = nonStart.GetPartialString(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}
