using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class CigarPartyTest
    {

        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()

        [TestMethod]
        public void CigarPartyTestHappyPath()
        {
            //haveParty(30, false) → false
            //haveParty(50, false) → true
            //aveParty(70, true) → true

            // Arrange - false
            CigarParty cigarParty = new CigarParty();
            bool expected = false;
            int inputOne = 30;
            bool intputTwo = false;

            bool result;

            // Act
            result = cigarParty.HaveParty(inputOne, intputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - true

            expected = true;
            inputOne = 70;
            intputTwo = true;

            // Act
            result = cigarParty.HaveParty(inputOne, intputTwo);

            // Assert
            Assert.AreEqual(expected, result);
           
            // Arrange - true

            expected = true;
            inputOne = 10000;
            intputTwo = true;

            // Act
            result = cigarParty.HaveParty(inputOne, intputTwo);

            // Assert
            Assert.AreEqual(expected, result);
            // Arrange - true

            expected = false;
            inputOne = 0;
            intputTwo = true;

            // Act
            result = cigarParty.HaveParty(inputOne, intputTwo);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CigarPartyTestException()
        {
            //haveParty(30, false) → false
            //haveParty(50, false) → true
            //aveParty(70, true) → true

            // Arrange - false
            CigarParty cigarParty = new CigarParty();
            bool expected = false;
            int inputOne = -50;
            bool intputTwo = true;

            bool result;

            // Act
            result = cigarParty.HaveParty(inputOne, intputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - false
           
             expected = false;
             inputOne = -1;
             intputTwo = true;

            // Act
            result = cigarParty.HaveParty(inputOne, intputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            // Arrange - false

            expected = false;
            inputOne = -10000;
            intputTwo = false;

            // Act
            result = cigarParty.HaveParty(inputOne, intputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            expected = true;
            inputOne = int.MaxValue;
            intputTwo = true;

            // Act
            result = cigarParty.HaveParty(inputOne, intputTwo);

            // Assert
            Assert.AreEqual(expected, result);


        }
    }
}
