﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 arrays of ints, a and b, return true if they have the same first element or they have
         the same last element. Both arrays will be length 1 or more.
         CommonEnd([1, 2, 3], [7, 3]) → true
         CommonEnd([1, 2, 3], [7, 3, 2]) → false
         CommonEnd([1, 2, 3], [1, 3]) → true
         */
        public bool CommonEnd(int[] a, int[] b)
        {


            if (b[b.Length - 1] == a[a.Length-1] || b[0] == a[0])
            {
                return true;
            }
            return false;

            
            }
        }
    }

        

    



