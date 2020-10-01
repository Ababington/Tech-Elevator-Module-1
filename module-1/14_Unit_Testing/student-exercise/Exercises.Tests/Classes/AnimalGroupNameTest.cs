using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class AnimalGroupNameTest
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
        public void AnimalGroupNameTestHappyPath()
        {
            //Rhino -> Crash
            //Giraffe -> Tower
            //Elephant -> Herd
            //Lion -> Pride
            //Crow -> Murder
            //Pigeon -> Kit
            //Flamingo -> Pat
            //Deer -> Herd
            //Dog -> Pack
            //Crocodile -> Float
            //"" -> "unknown"
            //walrus -> "unknown"
            //GetHerd("giraffe") → "Tower"
            //GetHerd("")-> "unknown"
            // GetHerd("walrus")-> "unknown"
            // GetHerd("Rhino")-> "Crash"
            // GetHerd("rhino")-> "Crash"
            // GetHerd("elephants")-> "unknown"


            // Arrange
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string expected = "Crash";
            string inputOne = "Rhino";

            string result = "";

            // Act
            result = animalGroupName.GetHerd(inputOne);

            // Assert
            Assert.AreEqual(expected, result);

            // let's do another - Giraffe
            inputOne = "Giraffe";

            expected = "Tower";

            // Act
            result = animalGroupName.GetHerd(inputOne);

            // Assert
            Assert.AreEqual(expected, result);

            // let's do another - Giraffe
            inputOne = "walrus";

            expected = "unknown";

            // Act
            result = animalGroupName.GetHerd(inputOne);

            // Assert
            Assert.AreEqual(expected, result);



        }

        [TestMethod]
        public void AnimalGroupNameTestExceptions()


        {

            // Arrange
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string expected = "unknown";
            string inputOne = "";

            string result = "";

            // Act
            result = animalGroupName.GetHerd(inputOne);

            // Assert
            Assert.AreEqual(expected, result);

            // Act
            string actually = animalGroupName.GetHerd(inputOne);

            // Assert
            Assert.AreEqual(expected, actually);

            // Arrange - null
            inputOne = null;
            expected = "unknown";

            // Act
            actually = animalGroupName.GetHerd(inputOne);

            // Assert
            Assert.AreEqual(expected, actually, "Sorry, product owner wants it to be null");

        }
    }
}
