﻿using System;
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
        int lapNumber = 1;

        public StopWatchPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromMilliseconds(50), () => { UpdateTime(); return true; });

        }

        void UpdateTime()
        {
            TimeSpan currentTime = sw.Elapsed;
            txtCurrentTime.Text = currentTime.ToString("hh\\:mm\\:ss\\.f");
        }

        void Lap()
        {
            lapTimes.Text += lapNumber.ToString() + ": " + sw.Elapsed.ToString("hh\\:mm\\:ss\\.f") + "\n";
            lapNumber += 1;
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

        void StopWatchReset(object sender, EventArgs e)
        {
            sw.Reset();
            lapTimes.Text = "";
            lapNumber = 1;

            if (running)
            {
                sw.Start();
            }
            else { }
        }
    }
}
