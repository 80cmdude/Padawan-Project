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
            Dice d1 = new Dice();
            Console.WriteLine("how many dice?");
            d1.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many sides on the dice?");
            d1.Sides = Convert.ToInt32(Console.ReadLine());
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
