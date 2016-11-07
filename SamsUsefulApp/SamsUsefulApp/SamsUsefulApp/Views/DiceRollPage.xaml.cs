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
