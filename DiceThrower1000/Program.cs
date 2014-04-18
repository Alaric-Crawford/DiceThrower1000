using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");

            Console.ReadKey();
        }
        //create ThrowDice function with string data type
        static void ThrowDice(string diceString)
        {
            Console.WriteLine("Throwing: " + diceString);
            //create variable that splits diceString to remove the 'd' from the value
            var dieNumAndVal = diceString.Split('d');
            //declare variables to store the two values
            int numDie = Convert.ToInt32(dieNumAndVal[0]);
            int valDie = Convert.ToInt32(dieNumAndVal[1]);
            //create Random() variable series
            var unpredictable = new Random();
            var value = unpredictable.Next(1, valDie+1);
            //make a loop to read both remaining numbers
            Console.Write("Results: ");
            for (var i = 1; i <= numDie; i++)
            {
                value = unpredictable.Next(1, valDie + 1);
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
