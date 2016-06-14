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
        public static void RollDice()
        {
            Console.WriteLine("How many dice?");
            int numOfDice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Sides?");
            int numOfSides = Convert.ToInt32(Console.ReadLine());
            Dice d1 = new Dice(numOfDice, numOfSides);
            if (d1.Sides == 0 || d1.Number == 0)
            {
                Console.WriteLine("Must input a number for Number of dice or sides");
            }
            else {
                Random rnd = new Random();
                Console.WriteLine("You Rolled:");
                List<int> arrayList = new List<int>();
                for (int i = 0; i < d1.Number; i++)
                {
                    int roll = rnd.Next(1, (d1.Sides + 1));
                    int totalRolled = roll;
                    arrayList.Add(totalRolled);
                }
                int total = arrayList.Sum();
                foreach (int item in arrayList)
                {
                    if (item == d1.Sides)
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
