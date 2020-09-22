using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string of odd length, return the string length 3 from its middle, so "Candy" yields "and".
         The string length will be at least 3.
         MiddleThree("Candy") → "and"
         MiddleThree("and") → "and"
         MiddleThree("solving") → "lvi"
         */
        public string MiddleThree(string str)
        {
            int length = str.Length;
            if (length == 3) return str;
            return str.Substring(length / 2 - 1, length / 2 + 2);
        }
    }
    
}
