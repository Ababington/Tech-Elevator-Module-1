using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class Less20Test
    {
        [TestMethod]
        public void Less20TestHappyPath()
        {
            //less20(18) → true
            //less20(19) → true
            //less20(20) → false

            // Arrange - 
            Less20 less20 = new Less20();
            int inputOne = 18;
            bool expected = true;
            bool result;

            // Act
            result = less20.IsLessThanMultipleOf20(inputOne);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - 

            inputOne = 8;
            expected = false;

            // Act
            result = less20.IsLessThanMultipleOf20(inputOne);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - 

            inputOne = 1;
            expected = false;

            // Act
            result = less20.IsLessThanMultipleOf20(inputOne);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Less20TestExceptions()
        {
            // Arrange - 
            Less20 less20 = new Less20();
            int inputOne = -2;
            bool expected = false;
            bool result;

            // Act
            result = less20.IsLessThanMultipleOf20(inputOne);

            // Assert
            Assert.AreEqual(expected, result);

        }
    }
}
