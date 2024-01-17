using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class RollDie
    {
       public int[] DiceRoll(int numRolls)
        {
            int[] resultArray = new int[numRolls];

            Random random = new Random();

            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                int randomNumber1 = random.Next(1, 7);
                int randomNumber2 = random.Next(1, 7);
                int total = randomNumber1 + randomNumber2;

                resultArray[iCount] = total;
            }
            return resultArray;
        }
    }
}
