using System;
using Xamarin.Forms;

namespace SamsApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnCopy(object sender, EventArgs e)
        {
            string copyText = userTextEntry.Text.ToString();
            if (!string.IsNullOrWhiteSpace(copyText))
            {
                copiedText.Text = copyText;
            }
            else
            {
                copiedText.Text = "Please enter some text to copy";
            }
        }
    }
}
