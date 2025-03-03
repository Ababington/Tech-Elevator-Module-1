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
         * Given an string item number (a.k.a. SKU), return the discount percentage if the item is on sale.
         * If the item is not on sale, return 0.00.
         *
         * If the item number is empty or null, return 0.00.
         *
         * "KITCHEN4001" -> 0.20
         * "GARAGE1070" -> 0.15
         * "LIVINGROOM"	-> 0.10
         * "KITCHEN6073" -> 0.40
         * "BEDROOM3434" -> 0.60
         * "BATH0073" -> 0.15
         *
         * The item number should be case insensitive so "kitchen4001", "Kitchen4001", and "KITCHEN4001"
         * should all return 0.20.
         *
         * IsItOnSale("kitchen4001") → 0.20
         * IsItOnSale("") → 0.00
         * IsItOnSale("GARAGE1070") → 0.15
         * IsItOnSale("dungeon9999") → 0.00
         *
         */
        public double IsItOnSale(string itemNumber)
        {
            Dictionary<string, double> discountPercentage = new Dictionary<string, double>();

            discountPercentage["KITCHEN4001"] = 0.20;
            discountPercentage["GARAGE1070"] = 0.15;
            discountPercentage["LIVINGROOM"] = 0.10;
            discountPercentage["KITCHEN6073"] = 0.40;
            discountPercentage["BEDROOM3434"] = 0.60;
            discountPercentage["BATH0073"] = 0.15;


           double discountString = 0.00;

            if (itemNumber == null || itemNumber == "")
            {
                return discountString;
            }
            else

            if (discountPercentage.ContainsKey(itemNumber.ToUpper()))
            {
                discountString = discountPercentage[itemNumber.ToUpper()];
            }
            return discountString;
           
        }
    }
}
