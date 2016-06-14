using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    public class Dice
    {
        public int Number { get; set; } //Sets the property of Number to my Dice object
        public int Sides { get; set; } //Sets the property of Number to my Dice object
        // Defines how to create a dice object to the rest of the application. Passes in an integer for Number of dice and sides of dice from elsewhere.
        public Dice() { }
        public Dice(int number, int sides) 
        {
            Number = number;
            Sides = sides; 
        }
    }
}
