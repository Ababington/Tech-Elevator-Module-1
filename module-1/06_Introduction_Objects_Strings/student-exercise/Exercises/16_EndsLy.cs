﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if it ends in "ly".
         EndsLy("oddly") → true
         EndsLy("y") → false
         EndsLy("oddy") → false
         */
        public bool EndsLy(string str)
        {


            bool containsLy = str.Contains("ly", StringComparison.InvariantCultureIgnoreCase);
           
            if (str.EndsWith("ly"))
            {
                return true;
            }
            
            {
                return false;
            }
               
        }
    }
}
