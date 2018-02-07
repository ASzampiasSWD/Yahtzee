using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjYahtzee
{
    class Dice
    {
        public int Value = 0;
        private Random rnd;

        /// <summary>
        /// Random MUST be the same instance or Dice will be too alike.
        /// </summary>
        /// <param name="rnd"></param>
        public Dice(Random rnd)
        {
            this.rnd = rnd;
        }

        /// <summary>
        /// RollDice() pick a random number between 1 and 6.
        /// </summary>
        /// <returns>Integer</returns>
        public int RollDice()
        {
            Value = rnd.Next(1, 7);
            return Value;
        }



    }
}
