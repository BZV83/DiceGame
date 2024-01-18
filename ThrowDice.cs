using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreC_Fun
{
    internal class ThrowDice
    {
        //use random for random numbers
        Random rand = new Random();

        public int[] DiceThrower(int numThrows)
        {
            //first position is meant to represent 2
            int[] outputArray = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

            //loop through and get dice rolls based on number of throws
            for (int i = 0; i < numThrows; i++)
            {
                int d1 = rand.Next(1, 7);
                int d2 = rand.Next(1, 7);
                //dice result
                int combinedDie = d1 + d2;

                //increment position in the array where correct combinedDie number lives
                //also adjust position by 2 to incorporate 0 based
                outputArray[combinedDie - 2] = outputArray[combinedDie - 2] + 1;
            }

            return outputArray;
        }
    }
}
