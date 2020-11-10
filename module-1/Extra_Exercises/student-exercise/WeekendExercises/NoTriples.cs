using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array. 
         Return true if the array does not contain any triples.
         noTriples([1, 1, 2, 2, 1]) → true
         noTriples([1, 1, 2, 2, 2, 1]) → false
         noTriples([1, 1, 1, 2, 2, 2, 1]) → false
         */
        public bool NoTriples(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a.Length >= 3)
                {
                    if (a[i] == a[i + 1] && a[i] == a[i + 2])
                    {
                        return false;
                    }
                }
              
            }
            return true;
        }
    }
}

