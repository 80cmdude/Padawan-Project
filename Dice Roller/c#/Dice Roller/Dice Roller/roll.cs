using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    public class roll 
    {
        public static void RollDice()
        {
            Console.WriteLine("How many dice?");
            int numDice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many sides on the dice?");
            int diceSides = Convert.ToInt32(Console.ReadLine());
            if (diceSides == 0 || numDice == 0)
            {
                Console.WriteLine("Must input a number for Number of dice or sides");
            }
            else {
                Random rnd = new Random();
                Console.WriteLine("You Rolled:");
                List<int> arrayList = new List<int>();
                for (int i = 0; i < numDice; i++)
                {
                    int roll = rnd.Next(1, (diceSides + 1));
                    int totalRolled = roll;
                    arrayList.Add(totalRolled);
                }
                int total = arrayList.Sum();
                foreach (int item in arrayList)
                {
                    if (item == diceSides)
                    {
                        Console.WriteLine(item.ToString() + " Crit!");
                    }
                    else
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                Console.WriteLine("Total: " + total);
            }
        }
    }
}
