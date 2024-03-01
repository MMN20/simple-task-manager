using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasky
{
    public partial class frmToolsScreen : Form
    {
        public frmToolsScreen(Label timer,Label timerText)
        {
            InitializeComponent();
            lblTimer = timer;
            lblTimerText = timerText;


        }
        TimeSpan ts = TimeSpan.Zero;
        Label lblTimer;
        Label lblTimerText;



        private void pauseFunction()
        {
            timer1.Stop();
            lblTimerText.Text = "Paused";
            btnStartPause.Text = "Start";

        }


        private void startFucntion()
        {
            if(ts ==  TimeSpan.Zero)
            {
                ts = new TimeSpan(0,(int)nudMinues.Value,(int)nudSeconds.Value);
            }
            lblTimerText.Text = "Work time";
            label4.Text = ts.TotalMinutes + ":" + ts.Seconds;
            nudMinues.Enabled = false;
            nudSeconds.Enabled = false;
            btnStartPause.Text = "Pause";
            timer1.Start();
        }


        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (btnStartPause.Text == "Start")
            {
                startFucntion();
            }
            else
                pauseFunction();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ts = ts.Subtract(TimeSpan.FromSeconds(1));
            label4.Text = (int)ts.TotalMinutes + ":" + ts.Seconds;

            if(ts == TimeSpan.Zero)
            {
                btnCancel.PerformClick();
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "Time to rest";
                notifyIcon1.ShowBalloonTip(3000);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            nudMinues.Enabled = true;
            nudSeconds.Enabled = true;
            lblTimerText.Text = "";
            label4.Text = "";
            btnStartPause.Text = "Start";
            ts = TimeSpan.Zero;
            timer1.Stop();

        }
    }
}
