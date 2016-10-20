using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsUsefulApp.Controllers.DiceRollPage
{
    public class DiceRoll
    {
        public string[] RollTheDice(int UserDiceInput, int UserSidesInput)
        {
            Dice UserDice = new Dice(UserDiceInput, UserSidesInput); // Creates a new instance of the Dice object from the Dice Class by passing in number and sides as integers.
            string[] rolledDice = Roll.RollDice(UserDice);  // Calls the RollDice() method and passes in the created Dice object
            return rolledDice;
        }
    }
}
