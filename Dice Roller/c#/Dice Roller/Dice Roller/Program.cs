using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    class Program
    {
        static void Main(string[] args) // The Method that runs when the application is started
        {
            while (true) //Keeps the Application open for a new roll
            {
                Console.WriteLine("How many dice?");
                int UserDiceInput = Convert.ToInt32(Console.ReadLine()); //Read value for Number of Dice
                Console.WriteLine("How many Sides?");
                int UserSidesInput = Convert.ToInt32(Console.ReadLine()); // Reads Value for Number of sides on each Dice
                if (UserSidesInput == 0 || UserDiceInput == 0) // Validates the Input is above 0. Does this before createing the object
                {
                    Console.WriteLine("Must input a number for Number of dice or sides");
                }
                else
                {
                    Dice UserDice = new Dice(UserDiceInput, UserSidesInput); // Creates a new instance of the Dice object from the Dice Class by passing in number and sides as integers.
                    roll.RollDice(UserDice); // Calls the RollDice() method and passes in the created Dice object
                }
            }
        } 
    }
}
