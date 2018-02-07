using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjYahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Random rnd = new Random();
            Dice dice1 = new Dice(rnd);
            Dice dice2 = new Dice(rnd);
            dice1.RollDice();
            Console.WriteLine(dice1.Value);
            dice2.RollDice();
            Console.WriteLine(dice2.Value); */

            Score scScore = new Score();
            bool meow = scScore.IsLargeStraight(new int[] {6,  2, 3, 4, 5 });
            Console.WriteLine(meow);
            bool testSmall = scScore.IsShortStraight(new int[] { 1, 2, 4, 3 });
            Console.WriteLine(testSmall);
            Console.Read();
        }
    }
}
