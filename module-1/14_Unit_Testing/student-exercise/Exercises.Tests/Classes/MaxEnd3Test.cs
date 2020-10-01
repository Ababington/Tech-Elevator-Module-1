using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]

        public void MaxEndTestHappyPath()
        {
            //MakeArray([1, 2, 3]) → [3, 3, 3]
            //MakeArray([11, 5, 9]) → [11, 11, 11]
            //MakeArray([2, 11, 3]) → [3, 3, 3]

            // Arrange - 
            MaxEnd3 maxEnd3 = new MaxEnd3();
            int[] array = { 1, 2, 3 };
            int[] expected = { 3, 3, 3 };
            int[] result;

            // Act
            result = maxEnd3.MakeArray(array);

            // Assert
            CollectionAssert.AreEqual(expected, result);

            // Arrange - 

            int[] array2 = { 12, 5, 8 };
            int[] expected2 = { 12, 12, 12 };
            int[] result2;

            // Act
            result2 = maxEnd3.MakeArray(array2);

            // Assert
            CollectionAssert.AreEqual(expected2, result2);
        }

        [TestMethod]

        public void MaxEndTestExpection()
        {
            // Arrange - 
            MaxEnd3 maxEnd3 = new MaxEnd3();
            int[] array = { 1, 2, 3, 4};
            int[] expected = { 4, 4, 4, 4};
            int[] result;

            // Act
            result = maxEnd3.MakeArray(array);

            // Assert
            CollectionAssert.AreEqual(expected, result);

        }
    }
}
