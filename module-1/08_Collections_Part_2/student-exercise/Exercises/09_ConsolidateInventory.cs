using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionaries, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2,
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         *
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *
         * ConsolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         *
         */
        // they give you 2 dictionaries (mainWarehouse, remoteWarhouse)
        // merge the two dictionaries into a new dictionary
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
            Dictionary<string, int> remoteWarehouse)
        {

            Dictionary<string, int> consolidatedInventory = new Dictionary<string, int>(mainWarehouse);

            foreach (KeyValuePair<string, int> tenetWarehouse in remoteWarehouse)
            {
                string key = tenetWarehouse.Key;
                int value = tenetWarehouse.Value;

                if (consolidatedInventory.ContainsKey(key))
                {
                    consolidatedInventory[key] += value;
                }
                else 
                {
                    consolidatedInventory[key] = value;
                }
            }
            return consolidatedInventory;
        }
    }
}
