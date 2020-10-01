using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class DateFashionTest
    {
        [TestMethod]
        public void DateFashionTestHappyPath()
        {
            //dateFashion(5, 10) → 2
            //dateFashion(5, 2) → 0
            //dateFashion(5, 5) → 1

            // Arrange 
            DateFashion dateFashion = new DateFashion();
            int expected = 2;
            int inputOne = 5;
            int inputTwo = 10;

            int result = 0;

            result = dateFashion.GetATable(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange 
            expected = 0;
            inputOne = 1;
            inputTwo = 8;

            result = 0;

            result = dateFashion.GetATable(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange 
            expected = 0;
            inputOne = 1;
            inputTwo = 1;

            result = 0;

            result = dateFashion.GetATable(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DateFashionTestException()
        {
            
            // Arrange 
            DateFashion dateFashion = new DateFashion();
            int expected = 2; // 1
            int inputOne = 5;
            int inputTwo = 30;

            int result = 0;

            result = dateFashion.GetATable(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange 
           
             expected = 0; // 1
             inputOne = -5;
             inputTwo = 7;

             result = 0;

            result = dateFashion.GetATable(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);
           

        }
    }
}
