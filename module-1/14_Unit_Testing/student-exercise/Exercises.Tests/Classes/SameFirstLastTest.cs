using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void SameFirstLastTestHappyPath()
        {
            //IsItTheSame([1, 2, 3]) → false
            //IsItTheSame([1, 2, 3, 1]) → true
            //IsItTheSame([1, 2, 1]) → true

            // Arrange - 
            SameFirstLast sameFirstLast = new SameFirstLast();
            int[] inputOne = { 1, 2, 3 };
            bool expected = false;
            bool result;

            // Act
            result = sameFirstLast.IsItTheSame(inputOne);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - 

            int[] inputTwo = { 3, 3, 3 };
            bool expected2 = true;
            bool result2;

            // Act
            result2 = sameFirstLast.IsItTheSame(inputTwo);

            // Assert
            Assert.AreEqual(expected2, result2);
        }
        [TestMethod]
        public void SameFirstLastTestException()
        {
            //IsItTheSame([1, 2, 3]) → false
            //IsItTheSame([1, 2, 3, 1]) → true
            //IsItTheSame([1, 2, 1]) → true

            // Arrange - 
            SameFirstLast sameFirstLast = new SameFirstLast();
            int[] inputOne = { };
            bool expected = false;
            bool result;

            // Act
            result = sameFirstLast.IsItTheSame(inputOne);

            // Assert
            Assert.AreEqual(expected, result);
            // Arrange - 

            int[] inputTwo = {-1,-2,-3 };
            bool expected2 = false;
            bool result2;

            // Act
            result2 = sameFirstLast.IsItTheSame(inputTwo);

            // Assert
            Assert.AreEqual(expected2, result2);

        }
    }
}
