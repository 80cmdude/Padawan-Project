using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dice_Roller;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanCreateObject()
        {
            Dice UserDice = new Dice(2, 6);
            Console.WriteLine("The Number of dice is " + UserDice.Number);
            Console.WriteLine("The Number of Sides each Dice has is " + UserDice.Sides);
        }
        [TestMethod]
        public void CanRollDice()
        {
            Dice UserDice = new Dice(1, 6);
            Dice_Roller.roll.RollDice(UserDice);
        }
        [TestMethod]
        public void CanFindZero()
        {
            Dice UserDice = new Dice(0, 6);
            if (UserDice.Number == 0 || UserDice.Sides == 0) // Validates the Input is above 0. Does this before createing the object
            {
                Console.WriteLine("Must input a number for Number of dice or sides");
            }
            else
            {
                Dice_Roller.roll.RollDice(UserDice);
            }
        }
    }
}
