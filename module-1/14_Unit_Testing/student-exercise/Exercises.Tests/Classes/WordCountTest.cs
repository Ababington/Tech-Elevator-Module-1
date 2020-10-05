using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void WordCountTestHappyPath()
        {
            //GetCount(["ba", "ba", "black", "sheep"]) → { "ba" : 2, "black": 1, "sheep": 1 }
            //GetCount(["a", "b", "a", "c", "b"]) → { "a": 2, "b": 2, "c": 1}
            //GetCount([]) → { }
            //GetCount(["c", "b", "a"]) → { "c": 1, "b": 1, "a": 1}

            // Arrange - 
            WordCount wordCount = new WordCount();
            string[] array1 = { "ba", "ba", "black", "sheep" };
            

            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };

            Dictionary<string, int> actual = wordCount.GetCount(array1);
            CollectionAssert.AreEqual(expected, actual);

            // Arrange - 
           
            string[] array2 = { };


            Dictionary<string, int> expected2 = new Dictionary<string, int>()
            {
                
            };

            Dictionary<string, int> actual2 = wordCount.GetCount(array2);
            CollectionAssert.AreEqual(expected2, actual2);
        }
    }
}
