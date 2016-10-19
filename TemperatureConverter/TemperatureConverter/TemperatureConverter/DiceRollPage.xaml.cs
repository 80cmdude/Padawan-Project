using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TemperatureConverter
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

            DiceRoll Roll = new DiceRoll();
            string[] resultArray = Roll.RollTheDice(numDice, numSides);
            string result = string.Join(", ", resultArray);
            txtRolledDice.Text = result;
        }
    }
}
