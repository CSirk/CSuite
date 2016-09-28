using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CTime
{
    public partial class Timer : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public static int hours, minutes, seconds, incrementProgressBarCounter;
        public static double numberOfSecondsForIncrementProgressBar;
        public static Color hoursColor, minutesColor, secondsColor;

        public Timer()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            this.Text = timerNameTextBox.Text;

            hoursNumeric.Visible = minutesNumeric.Visible = secondsNumeric.Visible = timerNameTextBox.Visible = aboveTimerNameLabel.Visible = false;
            hoursDisplayLabel.Visible = minutesDisplayLabel.Visible = secondsDisplayLabel.Visible = true;

            hours = Convert.ToInt32(hoursNumeric.Value);
            minutes = Convert.ToInt32(minutesNumeric.Value);
            seconds = Convert.ToInt32(secondsNumeric.Value);

            numberOfSecondsForIncrementProgressBar = ((hours * 360) + (minutes * 60) + seconds) / 100;

            countDownTimer.Start();

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            countDownTimer.Stop();
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            ChangeRemainingTime();
            ChangeProgressBar();

            hoursDisplayLabel.Text = ConvertTimeString(hours);
            minutesDisplayLabel.Text = ":" + ConvertTimeString(minutes);
            secondsDisplayLabel.Text = "." + ConvertTimeString(seconds);

            hoursDisplayLabel.ForeColor = hoursColor;
            minutesDisplayLabel.ForeColor = minutesColor;
            secondsDisplayLabel.ForeColor = secondsColor;
        }

        public string ConvertTimeString(int timeAmount)
        {
            if (timeAmount < 10)
            {
                return "0" + timeAmount;
            }
            else
            {
                return timeAmount.ToString();
            }
        }

        public void ChangeRemainingTime()
        {
            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                countDownTimer.Stop();
                var result = this.FindForm();
                var processId = System.Diagnostics.Process.GetCurrentProcess();

                var process = System.Diagnostics.Process.GetCurrentProcess();
                IntPtr pointer = process.MainWindowHandle;
                SetForegroundWindow(pointer);

                MessageBox.Show("Timer : " + timerNameTextBox.Text + " has expired.");
            }
            else
            {
                if (seconds == 0)
                {
                    if (minutes == 0)
                    {
                        hours -= 1;
                        minutes = 59;
                        seconds = 59;
                        hoursColor = Color.Red;
                        minutesColor = Color.Blue;
                        secondsColor = Color.Blue;
                    }
                    else
                    {
                        minutes -= 1;
                        seconds = 59;
                        hoursColor = Color.Blue;
                        minutesColor = Color.Red;
                        secondsColor = Color.Blue;
                    }
                }
                else
                {
                    seconds -= 1;
                    hoursColor = Color.Blue;
                    minutesColor = Color.Blue;
                    secondsColor = Color.Red;
                }
            }

            hoursNumeric.Value = hours;
            minutesNumeric.Value = minutes;
            secondsNumeric.Value = seconds;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            countDownTimer.Stop();
            hoursNumeric.Visible = minutesNumeric.Visible = secondsNumeric.Visible = timerNameTextBox.Visible = aboveTimerNameLabel.Visible = true;
            hoursDisplayLabel.Visible = minutesDisplayLabel.Visible = secondsDisplayLabel.Visible = false;
            hoursNumeric.Value = minutesNumeric.Value = secondsNumeric.Value = 0;
            hoursDisplayLabel.Text = minutesDisplayLabel.Text = secondsDisplayLabel.Text = "";
            progressBar1.Value = 0;

        }

        public void ChangeProgressBar()
        {
            incrementProgressBarCounter++;

            if (incrementProgressBarCounter >= numberOfSecondsForIncrementProgressBar)
            {
                progressBar1.Increment(1);
                incrementProgressBarCounter = 0;
            }

        }
    }
}
