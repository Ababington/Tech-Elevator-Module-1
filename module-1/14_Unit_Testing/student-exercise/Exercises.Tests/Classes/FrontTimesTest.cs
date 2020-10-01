using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void FrontTimesTestHappyPath()
        {
            //frontTimes("Chocolate", 2) → "ChoCho"
            //frontTimes("Chocolate", 3) → "ChoChoCho"
            //frontTimes("Abc", 3) → "AbcAbcAbc"

            // Arrange - 
            FrontTimes frontTimes = new FrontTimes();
            string stringOne = "Chocolate";
            int inputTwo = 2;
            string expected = "ChoCho";

            string result = "";

            // Act
            result = frontTimes.GenerateString(stringOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - 

            stringOne = "Rgb";
            inputTwo = 4;
            expected = "RgbRgbRgbRgb";

            result = "";

            // Act
            result = frontTimes.GenerateString(stringOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);
            stringOne = "D";
            inputTwo = 1;
            expected = "D";

            result = "";

            // Act
            result = frontTimes.GenerateString(stringOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);
            stringOne = "Tenet";
            inputTwo = 2;
            expected = "TenTen";

            result = "";

            // Act
            result = frontTimes.GenerateString(stringOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void FrontTimesTestException()
        {
          
            // Arrange - 
            FrontTimes frontTimes = new FrontTimes();
            string stringOne = "Chocolate";
            int inputTwo = -2;
            string expected = "";

            string result = "";
            
            // Act
            result = frontTimes.GenerateString(stringOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);

        }
    }
}
