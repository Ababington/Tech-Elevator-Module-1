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
         * Modify and return the given Dictionary as follows: if "Peter" has more than 0 money, transfer half of it to "Paul",
         * but only if Paul has less than $10s.
         *
         * Note, monetary amounts are specified in cents: penny=1, nickel=5, ... $1=100, ... $10=1000, ...
         *
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 99}) → {"Peter": 1000, "Paul": 1099}
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 30000}) → {"Peter": 2000, "Paul": 30000}
         *
         */

        //Given the Dictionary. Does Peter have more than 0 dollars, if so transfer half to Paul, but only if Paul as less then 10
        public Dictionary<string, int> RobPeterToPayPaul(Dictionary<string, int> peterPaul)
        {


            if(peterPaul["Paul"] < 1000 && peterPaul["Peter"] > 0)
            {
                int tenet = peterPaul["Peter"] / 2;
                int paul = peterPaul["Paul"];

                peterPaul["Paul"] = tenet + peterPaul["Paul"];
                peterPaul["Peter"] = tenet;
            }
            return peterPaul;
        }
    }
}
