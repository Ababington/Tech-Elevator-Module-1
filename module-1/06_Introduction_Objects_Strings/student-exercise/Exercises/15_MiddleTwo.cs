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
         Given a string of even length, return a string made of the middle two chars, so the string "string"
         yields "ri". The string length will be at least 2.
         MiddleTwo("string") → "ri"
         MiddleTwo("code") → "od"
         MiddleTwo("Practice") → "ct"
         */
        public string MiddleTwo(string str)
        {

            if (str.Length % 2 == 0)
            {

                string firstLast = str.Substring(0, str.Length / 2);
                string lastHalf = str.Substring(str.Length / 2);
                string removedFirst = firstLast.Substring(firstLast.Length - 1);
                string removedLast = lastHalf.Substring(0, 1);

                return removedFirst+ removedLast;
            }
            return "";
            
        }
    }
}
