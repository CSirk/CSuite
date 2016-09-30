namespace CTime
{
    partial class Timer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.aboveTimerNameLabel = new System.Windows.Forms.Label();
            this.timerNameTextBox = new System.Windows.Forms.TextBox();
            this.secondsDisplayLabel = new System.Windows.Forms.Label();
            this.minutesDisplayLabel = new System.Windows.Forms.Label();
            this.hoursDisplayLabel = new System.Windows.Forms.Label();
            this.secondsNumeric = new System.Windows.Forms.NumericUpDown();
            this.minutesNumeric = new System.Windows.Forms.NumericUpDown();
            this.hoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.secondsAboveLabel = new System.Windows.Forms.Label();
            this.minutesAboveLabel = new System.Windows.Forms.Label();
            this.hoursAboveLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).BeginInit();
            this.SuspendLayout();
            //
            // progressBar1
            //
            this.progressBar1.Location = new System.Drawing.Point(148, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(128, 10);
            this.progressBar1.TabIndex = 35;
            this.progressBar1.Visible = false;
            //
            // aboveTimerNameLabel
            //
            this.aboveTimerNameLabel.AutoSize = true;
            this.aboveTimerNameLabel.Location = new System.Drawing.Point(145, 9);
            this.aboveTimerNameLabel.Name = "aboveTimerNameLabel";
            this.aboveTimerNameLabel.Size = new System.Drawing.Size(64, 13);
            this.aboveTimerNameLabel.TabIndex = 34;
            this.aboveTimerNameLabel.Text = "Timer Name";
            //
            // timerNameTextBox
            //
            this.timerNameTextBox.Location = new System.Drawing.Point(148, 25);
            this.timerNameTextBox.Name = "timerNameTextBox";
            this.timerNameTextBox.Size = new System.Drawing.Size(128, 20);
            this.timerNameTextBox.TabIndex = 33;
            //
            // secondsDisplayLabel
            //
            this.secondsDisplayLabel.AutoSize = true;
            this.secondsDisplayLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsDisplayLabel.Location = new System.Drawing.Point(88, 22);
            this.secondsDisplayLabel.Name = "secondsDisplayLabel";
            this.secondsDisplayLabel.Size = new System.Drawing.Size(54, 37);
            this.secondsDisplayLabel.TabIndex = 32;
            this.secondsDisplayLabel.Text = ".00";
            this.secondsDisplayLabel.Visible = false;
            //
            // minutesDisplayLabel
            //
            this.minutesDisplayLabel.AutoSize = true;
            this.minutesDisplayLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesDisplayLabel.Location = new System.Drawing.Point(44, 22);
            this.minutesDisplayLabel.Name = "minutesDisplayLabel";
            this.minutesDisplayLabel.Size = new System.Drawing.Size(54, 37);
            this.minutesDisplayLabel.TabIndex = 31;
            this.minutesDisplayLabel.Text = ":00";
            this.minutesDisplayLabel.Visible = false;
            //
            // hoursDisplayLabel
            //
            this.hoursDisplayLabel.AutoSize = true;
            this.hoursDisplayLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursDisplayLabel.Location = new System.Drawing.Point(7, 22);
            this.hoursDisplayLabel.Name = "hoursDisplayLabel";
            this.hoursDisplayLabel.Size = new System.Drawing.Size(47, 37);
            this.hoursDisplayLabel.TabIndex = 30;
            this.hoursDisplayLabel.Text = "00";
            this.hoursDisplayLabel.Visible = false;
            //
            // secondsNumeric
            //
            this.secondsNumeric.Location = new System.Drawing.Point(104, 22);
            this.secondsNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsNumeric.Name = "secondsNumeric";
            this.secondsNumeric.Size = new System.Drawing.Size(38, 20);
            this.secondsNumeric.TabIndex = 29;
            //
            // minutesNumeric
            //
            this.minutesNumeric.Location = new System.Drawing.Point(60, 22);
            this.minutesNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNumeric.Name = "minutesNumeric";
            this.minutesNumeric.Size = new System.Drawing.Size(38, 20);
            this.minutesNumeric.TabIndex = 28;
            //
            // hoursNumeric
            //
            this.hoursNumeric.Location = new System.Drawing.Point(15, 22);
            this.hoursNumeric.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursNumeric.Name = "hoursNumeric";
            this.hoursNumeric.Size = new System.Drawing.Size(38, 20);
            this.hoursNumeric.TabIndex = 27;
            //
            // secondsAboveLabel
            //
            this.secondsAboveLabel.AutoSize = true;
            this.secondsAboveLabel.Location = new System.Drawing.Point(101, 9);
            this.secondsAboveLabel.Name = "secondsAboveLabel";
            this.secondsAboveLabel.Size = new System.Drawing.Size(14, 13);
            this.secondsAboveLabel.TabIndex = 26;
            this.secondsAboveLabel.Text = "S";
            //
            // minutesAboveLabel
            //
            this.minutesAboveLabel.AutoSize = true;
            this.minutesAboveLabel.Location = new System.Drawing.Point(57, 9);
            this.minutesAboveLabel.Name = "minutesAboveLabel";
            this.minutesAboveLabel.Size = new System.Drawing.Size(16, 13);
            this.minutesAboveLabel.TabIndex = 25;
            this.minutesAboveLabel.Text = "M";
            //
            // hoursAboveLabel
            //
            this.hoursAboveLabel.AutoSize = true;
            this.hoursAboveLabel.Location = new System.Drawing.Point(12, 9);
            this.hoursAboveLabel.Name = "hoursAboveLabel";
            this.hoursAboveLabel.Size = new System.Drawing.Size(15, 13);
            this.hoursAboveLabel.TabIndex = 24;
            this.hoursAboveLabel.Text = "H";
            //
            // startButton
            //
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.startButton.Location = new System.Drawing.Point(15, 67);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(83, 36);
            this.startButton.TabIndex = 23;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            //
            // resetButton
            //
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.resetButton.Location = new System.Drawing.Point(193, 67);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(83, 36);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            //
            // stopButton
            //
            this.stopButton.BackColor = System.Drawing.Color.Black;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.stopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.stopButton.Location = new System.Drawing.Point(104, 67);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(83, 36);
            this.stopButton.TabIndex = 21;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            //
            // countDownTimer
            //
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            //
            // Timer
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.aboveTimerNameLabel);
            this.Controls.Add(this.timerNameTextBox);
            this.Controls.Add(this.secondsDisplayLabel);
            this.Controls.Add(this.minutesDisplayLabel);
            this.Controls.Add(this.hoursDisplayLabel);
            this.Controls.Add(this.secondsNumeric);
            this.Controls.Add(this.minutesNumeric);
            this.Controls.Add(this.hoursNumeric);
            this.Controls.Add(this.secondsAboveLabel);
            this.Controls.Add(this.minutesAboveLabel);
            this.Controls.Add(this.hoursAboveLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Name = "Timer";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label aboveTimerNameLabel;
        private System.Windows.Forms.TextBox timerNameTextBox;
        private System.Windows.Forms.Label secondsDisplayLabel;
        private System.Windows.Forms.Label minutesDisplayLabel;
        private System.Windows.Forms.Label hoursDisplayLabel;
        private System.Windows.Forms.NumericUpDown secondsNumeric;
        private System.Windows.Forms.NumericUpDown minutesNumeric;
        private System.Windows.Forms.NumericUpDown hoursNumeric;
        private System.Windows.Forms.Label secondsAboveLabel;
        private System.Windows.Forms.Label minutesAboveLabel;
        private System.Windows.Forms.Label hoursAboveLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer countDownTimer;
    }
}

