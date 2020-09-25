using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {


        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */


        //they give you the non-empty string. (words)
        //return a Dictonary<string,string> (make new dictionary)
        //fill with KEY of first letter and value of last for every word. (put key "words" in dictionary "book")
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> FirstAndLast = new Dictionary<string, string>();
            
            foreach (string tenet in words)
            {
               FirstAndLast[tenet.Substring(0, 1)] = tenet.Substring(tenet.Length - 1);
            }

            return FirstAndLast;
        }
    }
}
