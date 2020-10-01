using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]

        public void Lucky13TestHappyPath()
        {
            //GetLucky([0, 2, 4]) → true
            // GetLucky([1, 2, 3]) → false
            //GetLucky([1, 2, 4]) → false
            // Arrange - 
            Lucky13 lucky13 = new Lucky13();
            int[] array = { 0, 0, 0 };
            bool expected = true;
            bool result;

            // Act
            result = lucky13.GetLucky(array);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - 

            int[] array2 = { 0, 0, 0, 0 };
            expected = true;

            // Act
            result = lucky13.GetLucky(array2);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - 

            int[] array3 = { 1, 3, 3, 3, 3, 3 };
            expected = false;

            // Act
            result = lucky13.GetLucky(array3);

            // Assert
            Assert.AreEqual(expected, result);

            //Arrange
            int[] array4 = { -1, 4, 5 };
            expected = true;


            // Act
            result = lucky13.GetLucky(array4);

            // Assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]

        public void Lucky13TestException()
        {

            Lucky13 lucky13 = new Lucky13();
            int[] array = { };
            bool expected = true;
            bool result;

            // Act
            result = lucky13.GetLucky(array);

            // Assert
            Assert.AreEqual(expected, result);


        }
    }
}
