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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string result = "";

            if (str.Length > 1)
            {

                for (int i = 0; i < str.Length; i++)
                {
                    if (!(i > 0 && i < (str.Length - 1) && str.Substring(i, i + 1).Equals('x')))
                    {
                        result = result + str.Substring(i, i + 1);
                    }
                }
                return result;
            }
        }
    }
}
