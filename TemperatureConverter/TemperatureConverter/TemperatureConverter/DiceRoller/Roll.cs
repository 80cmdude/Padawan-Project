using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Roll
    {
        public static string[] RollDice(Dice d1) // START ROLLING THE DICE -- Defining that a Dice object needs to be passed in to this function and calling it d1
        {
            Random rnd = new Random(); // creates a random number and stores it as the variable rnd
            List<int> arrayList = new List<int>(); // Creates a new empty array(list) of numbers
            for (int i = 0; i < d1.Number; i++) // Rolling the dice 1 at a time until the full amount have been rolled
            {
                int roll = rnd.Next(1, (d1.Sides + 1)); // returns a random value between 1 and the number of sides+1
                int totalRolled = roll; // sets the value the roll landed on
                arrayList.Add(totalRolled); // adds the value of the roll to the array
            }
            int total = arrayList.Sum(); // Sum of the array is defined here before I add text.

            string[] rolledDice = arrayList.Select(i => i.ToString()).ToArray();
            return rolledDice;
        }
    }
}
