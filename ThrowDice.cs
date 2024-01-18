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
            //Each position in array represents potential rolled number starting at 2 and ending at 12
            int[] outputArray = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

            //loop through and get dice rolls based on number of throws
            for (int iCount = 0; iCount < numThrows; iCount++)
            {
                int d1 = rand.Next(1, 7);
                int d2 = rand.Next(1, 7);
                //dice result
                int combinedDie = d1 + d2;

                //increment position in the array where correct combinedDie number lives
                //also adjust position by 2 to incorporate 0 based outputArray
                outputArray[combinedDie - 2] = outputArray[combinedDie - 2] + 1;
            }

            return outputArray;
        }
    }
}
