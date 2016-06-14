using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How many dice?");
                int UserDiceInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many Sides?");
                int UserSidesInout = Convert.ToInt32(Console.ReadLine());
                roll.RollDice(UserDiceInput, UserSidesInout);
            }
        } 
    }
}
