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
            btnClear = new Button();
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
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(59, 105);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 1;
            btnStop.Text = "S&top";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(274, 265);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(207, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tbStartTime
            // 
            tbStartTime.Location = new Point(274, 48);
            tbStartTime.Name = "tbStartTime";
            tbStartTime.Size = new Size(207, 23);
            tbStartTime.TabIndex = 3;
            tbStartTime.TextChanged += tbStartTime_TextChanged;
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
            lblStartTime.Location = new Point(208, 52);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(60, 15);
            lblStartTime.TabIndex = 6;
            lblStartTime.Text = "Start Time";
            // 
            // lblStopTime
            // 
            lblStopTime.AutoSize = true;
            lblStopTime.Location = new Point(212, 109);
            lblStopTime.Name = "lblStopTime";
            lblStopTime.Size = new Size(56, 15);
            lblStopTime.TabIndex = 7;
            lblStopTime.Text = "End Time";
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Location = new Point(176, 166);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(92, 15);
            lblElapsedTime.TabIndex = 8;
            lblElapsedTime.Text = "Elapsed Time (s)";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(59, 162);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 326);
            Controls.Add(btnClear);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnClear;
    }
}
