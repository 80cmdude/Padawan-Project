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
            Int16 numDice = Convert.ToInt16(numberOfDice.Text);
            Int16 numSides = Convert.ToInt16(numberOfSides.Text);

            if (numDice > 1000)
            {
                Alerts.InvalidInput(messageToUser:"You cannot roll more than 1000 dice");
            }
            else if (numSides > 1000)
            {
                Alerts.InvalidInput(messageToUser: "You cannot roll a dice with over 1000 sides");
            }

            else
            {
                RollResult result = Roll.RollDice(numDice, numSides);
                string results = string.Join(", ", result.Results);
                txtRolledDice.Text = results;

                total.Text = result.Total.ToString();
            }
        }
    }
}
