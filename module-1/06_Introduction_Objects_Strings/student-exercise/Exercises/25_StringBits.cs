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
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         StringBits("Hello") → "Hlo"
         StringBits("Hi") → "H"
         StringBits("Heeololeo") → "Hello"
         */
        public string StringBits(string str)
        {
            int length = str.Length;

            string num = "";

            for (int i = 0; i < length; i += 2)
            {

                num += str[i];

            }

            return num;

        }
    }
}
