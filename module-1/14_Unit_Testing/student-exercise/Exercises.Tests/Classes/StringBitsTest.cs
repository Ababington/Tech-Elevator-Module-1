using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void StringBitsTestHappyPath()
        {
            //GetBits("Hello") → "Hlo"
            //GetBits("Hi") → "H"
            //GetBits("Heeololeo") → "Hello"

            // Arrange - 
            StringBits stringBits = new StringBits();
            string inputOne = "Hello";
            string expected = "Hlo";
            string result = "";

            // Act
            result = stringBits.GetBits(inputOne);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange
            inputOne = "Tenet";
            expected = "Tnt";
            result = "";

            // Act
            result = stringBits.GetBits(inputOne);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StringBitsTestException()
        {
           
            // Arrange - 
            StringBits stringBits = new StringBits();
            string inputOne = "";
            string expected = "";
            string result = "";

            // Act
            result = stringBits.GetBits(inputOne);

            // Assert
            Assert.AreEqual(expected, result);

        }
    }
}
