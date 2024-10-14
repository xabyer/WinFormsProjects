namespace Pr01StopWatch
{
    partial class frmMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            btnExit = new Button();
            tbStartTime = new TextBox();
            tbStopTime = new TextBox();
            tbElapsedTime = new TextBox();
            lblStartTime = new Label();
            lblStopTime = new Label();
            lblElapsedTime = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(59, 48);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(59, 105);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 1;
            btnStop.Text = "S&top";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(274, 265);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(207, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // tbStartTime
            // 
            tbStartTime.Location = new Point(274, 48);
            tbStartTime.Name = "tbStartTime";
            tbStartTime.Size = new Size(207, 23);
            tbStartTime.TabIndex = 3;
            // 
            // tbStopTime
            // 
            tbStopTime.Location = new Point(274, 105);
            tbStopTime.Name = "tbStopTime";
            tbStopTime.Size = new Size(207, 23);
            tbStopTime.TabIndex = 4;
            // 
            // tbElapsedTime
            // 
            tbElapsedTime.Location = new Point(274, 163);
            tbElapsedTime.Name = "tbElapsedTime";
            tbElapsedTime.Size = new Size(207, 23);
            tbElapsedTime.TabIndex = 5;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(158, 56);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(60, 15);
            lblStartTime.TabIndex = 6;
            lblStartTime.Text = "Start Time";
            // 
            // lblStopTime
            // 
            lblStopTime.AutoSize = true;
            lblStopTime.Location = new Point(158, 113);
            lblStopTime.Name = "lblStopTime";
            lblStopTime.Size = new Size(56, 15);
            lblStopTime.TabIndex = 7;
            lblStopTime.Text = "End Time";
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Location = new Point(158, 171);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(92, 15);
            lblElapsedTime.TabIndex = 8;
            lblElapsedTime.Text = "Elapsed Time (s)";
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblElapsedTime);
            Controls.Add(lblStopTime);
            Controls.Add(lblStartTime);
            Controls.Add(tbElapsedTime);
            Controls.Add(tbStopTime);
            Controls.Add(tbStartTime);
            Controls.Add(btnExit);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "frmMainForm";
            Text = "Stop Watch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Button btnExit;
        private TextBox tbStartTime;
        private TextBox tbStopTime;
        private TextBox tbElapsedTime;
        private Label lblStartTime;
        private Label lblStopTime;
        private Label lblElapsedTime;
    }
}
