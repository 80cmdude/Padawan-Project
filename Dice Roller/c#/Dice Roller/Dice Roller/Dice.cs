using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    public class Dice
    {
        public int Number { get; set; }
        public int Sides { get; set; }
        public Dice() { }
        public Dice(int number, int sides)
        {
            Number = number;
            Sides = sides; 
        }
    }
}
