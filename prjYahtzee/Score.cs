using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjYahtzee
{
    class Score
    {
        public Score()
        {

        }


        public bool IsLargeStraight(int[] arDice)
        {
            int[] arAnswer = { 1, 2, 3, 4, 5 };
            int[] arAnswer2 = { 2, 3, 4, 5, 6 };
            Array.Sort(arDice);
            if (arDice.SequenceEqual(arAnswer) || arDice.SequenceEqual(arAnswer2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsShortStraight(int[] arDice)
        {
            if (arDice.Length != 4)
            {
                return false;
            }

            Array.Sort(arDice);
            int intCount = arDice[0];

            foreach (int intDiceValue in arDice)
            {
                if (intDiceValue == intCount)
                {
                    intCount++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }




    }
}
