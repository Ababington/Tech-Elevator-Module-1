using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses.Classes;

namespace TestableClassesTestLive.Classes
{
    [TestClass]
    public class LoopsAndArrayExercisesTest
    {
        [TestMethod]
        public void MiddleWayTestHappyPath()
        {
            //     middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
            //middleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
            //middleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
           
            //Arrange
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises();
            int[] first = { 1, 2, 3 };
            int[] second = { 4, 5, 6 };
            int[] expected = { 2, 5 };

            //Act
            int[] result = loopsAndArrayExercises.MiddleWay(first, second);

            //assert 
            CollectionAssert.AreEqual(expected, result);
        }

    }
}
