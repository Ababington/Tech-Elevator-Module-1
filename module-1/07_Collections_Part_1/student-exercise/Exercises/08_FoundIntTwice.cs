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
         Given a List of Integers, and an int value, return true if the int value appears two or more times in
         the list.
         FoundIntTwice( [5, 7, 9, 5, 11], 5 ) -> true
         FoundIntTwice( [6, 8, 10, 11, 13], 8 -> false
         FoundIntTwice( [9, 23, 44, 2, 88, 44], 44) -> true
         */
        public bool FoundIntTwice(List<int> integerList, int intToFind)
        {
            for (int i = 0; i < integerList.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (integerList[j] == integerList[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
