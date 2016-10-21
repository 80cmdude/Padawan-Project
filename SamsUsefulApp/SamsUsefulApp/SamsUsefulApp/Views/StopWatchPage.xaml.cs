using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;

namespace SamsUsefulApp.Views
{
    public partial class StopWatchPage : ContentPage
    {
        Stopwatch sw = new Stopwatch();
        bool running = false;

        public StopWatchPage()
        {
            InitializeComponent();
            txtCurrentTime.Text = sw.Elapsed.Seconds.ToString();
        }

        void StopWatchStart(object sender, EventArgs e)
        {
            
            if (running == false)
            {
                sw.Start();
                running = true;
                btnStartTime.Text = "Stop";
            }
            else if (running == true)
            {
                sw.Stop();
                running = false;
                btnStartTime.Text = "Start";
            }
        }
    }
}
