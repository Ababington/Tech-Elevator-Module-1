﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        // they give array (words)
        // return Dictionry (make new dictionary)
        // put in a key of each different string with the value the number of times that string appears
        //
        //
        //
        //
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string timesWord in words)
            {
                if (wordCount.ContainsKey(timesWord))
                {
                    wordCount[timesWord] = wordCount[timesWord] + 1;
                }
                else
                {
                    wordCount[timesWord] = 1;
                }
            }
            return wordCount;
        }
    }
}
