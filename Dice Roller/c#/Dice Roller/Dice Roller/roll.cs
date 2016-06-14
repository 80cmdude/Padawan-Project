using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dice_Roller;

namespace Dice_Roller
{
    public class roll
    {
        public static void RollDice(Dice d1) // Defining that a Dice object needs to be passed in to this function and calling it d1
        {
            if (d1.Sides == 0 || d1.Number == 0)
            {
                Console.WriteLine("Must input a number for Number of dice or sides");
            }
            else {
                Random rnd = new Random(); // creates a random number and stores it as the variable rnd
                Console.WriteLine("You Rolled:");
                List<int> arrayList = new List<int>(); // Creates a new empty array of numbers
                for (int i = 0; i < d1.Number; i++)
                {
                    int roll = rnd.Next(1, (d1.Sides + 1)); // returns a random value between 1 and the number of sides+1
                    int totalRolled = roll; // sets the value the roll landed on
                    arrayList.Add(totalRolled); // adds the value to the array
                }
                int total = arrayList.Sum(); // Sum of the array is defined here before i add text.
                foreach (int item in arrayList) // ForEach loop to write out all the elements of the array
                {
                    if (item == d1.Sides)
                    {
                        Console.WriteLine(item.ToString() + " Crit!"); // Add the the term Crit if a roll hits the maximum value
                    }
                    else
                    {
                        Console.WriteLine(item.ToString()); // prints the value in the array
                    }
                }
                Console.WriteLine("Total: " + total); //Displays the total rolled of all dice.
            }
        }
    }
}
