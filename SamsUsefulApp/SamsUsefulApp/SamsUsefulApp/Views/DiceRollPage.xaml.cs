using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamsUsefulApp.Controllers.DiceRollPage;

using Xamarin.Forms;

namespace SamsUsefulApp.Views
{
    public partial class DiceRollPage : ContentPage
    {
        public DiceRollPage()
        {
            InitializeComponent();
        }

        void RollDice(object sender, EventArgs e)
        {
            int numDice = Convert.ToInt32(numberOfDice.Text);
            int numSides = Convert.ToInt32(numberOfSides.Text);

            if (numDice > 100 || numSides > 100)
            {
                txtRolledDice.Text = "You cannot roll more than 100 dice or a dice with over 100 sides";
            }

            else
            {
                DiceRoll Roll = new DiceRoll();
                string[] resultArray = Roll.RollTheDice(numDice, numSides);
                string result = string.Join(", ", resultArray);
                txtRolledDice.Text = result;

                List<int> totalArray = new List<int>();
                foreach (var i in resultArray)
                {
                    totalArray.Add(Convert.ToInt16(i));
                }

                total.Text = totalArray.Sum().ToString();
            }
        }
    }
}
