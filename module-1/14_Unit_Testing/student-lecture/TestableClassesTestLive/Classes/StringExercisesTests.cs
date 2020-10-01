using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses.Classes;

namespace TestableClassesTestLive.Classes
{
    [TestClass]
    public class StringExercisesTests
    {
        [TestMethod]
        public void MakeAbbaTestHappyPath()


        {
            //makeAbba("Hi", "Bye") → "HiByeByeHi"
            //makeAbba("Yo", "Alice") → "YoAliceAliceYo"
            //makeAbba("What", "Up") → "WhatUpUpWhat"
            //makeAbba("Henry", "Mimi") → "HenryMimiMimiHenry"
            //makeAbba("Tech", "Elevator") → "TechElevatorElevatorTech"

            //Arrange
            StringExercises stringExercises = new StringExercises();
            string expected = "HiByeByeHi";
            string inputOne = "Hi";
            string inputTwo = "Bye";
            string result = "";

            //Act
            result = stringExercises.MakeAbba(inputOne, inputTwo);


            // Assert
            Assert.AreEqual(expected, result);
            //lets do another
             expected = "HenryMimiMimiHenry";
             inputOne = "Henry";
             inputTwo = "Mimi";
            
            result = stringExercises.MakeAbba(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expected, result);

            //Arrange
            inputOne = null;
            expected = null;

            string actually = stringExercises.MakeAbba(inputOne, inputTwo);

            Assert.AreEqual(expected, actually,"Sorry, product owner wants it to be null");
        }
    }
}
