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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            int countOfXs = str.IndexOf("x");
            
            bool containsXx = str.Contains("xx", StringComparison.InvariantCultureIgnoreCase);
            if (containsXx)
            {


                if (countOfXs < str.Length - 1 && str[countOfXs + 1] == 'x')
                {

                    return true;
                }
                else
               
                {
                    return false;
                }
            }
            return false;
        }


    }
}



