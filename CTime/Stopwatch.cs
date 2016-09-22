using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTime
{
    public partial class Stopwatch : Form
    {
        private System.Windows.Forms.Timer _stopWatchTimer;

        public Stopwatch()
        {
            InitializeComponent();
            stopwatchTimer = new System.Windows.Forms.Timer();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();
            stopwatchTimer = new System.Windows.Forms.Timer();
        }

        private void stopwatchTimer_Tick(object sender, EventArgs e)
        {
            stopwatchLabel.Text = stopwatchTimer.ToString();
        }
    }
}
