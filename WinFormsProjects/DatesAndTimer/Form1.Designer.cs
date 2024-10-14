namespace DatesAndTimer
{
    partial class frmDatesTimer
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
            components = new System.ComponentModel.Container();
            lblDayOfWeek = new Label();
            lblTime = new Label();
            lblMonth = new Label();
            lblDayOfMonth = new Label();
            lblYear = new Label();
            btnStart = new Button();
            timTime = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Location = new Point(98, 61);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(38, 15);
            lblDayOfWeek.TabIndex = 0;
            lblDayOfWeek.Text = "label1";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(98, 136);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(38, 15);
            lblTime.TabIndex = 1;
            lblTime.Text = "label2";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(504, 61);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(38, 15);
            lblMonth.TabIndex = 2;
            lblMonth.Text = "label3";
            // 
            // lblDayOfMonth
            // 
            lblDayOfMonth.AutoSize = true;
            lblDayOfMonth.Location = new Point(504, 136);
            lblDayOfMonth.Name = "lblDayOfMonth";
            lblDayOfMonth.Size = new Size(38, 15);
            lblDayOfMonth.TabIndex = 3;
            lblDayOfMonth.Text = "label4";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(504, 226);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(38, 15);
            lblYear.TabIndex = 4;
            lblYear.Text = "label5";
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Bottom;
            btnStart.Location = new Point(0, 350);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(800, 100);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timTime
            // 
            timTime.Interval = 1000;
            timTime.Tick += timTime_Tick;
            // 
            // frmDatesTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(lblYear);
            Controls.Add(lblDayOfMonth);
            Controls.Add(lblMonth);
            Controls.Add(lblTime);
            Controls.Add(lblDayOfWeek);
            Name = "frmDatesTimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dates and Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDayOfWeek;
        private Label lblTime;
        private Label lblMonth;
        private Label lblDayOfMonth;
        private Label lblYear;
        private Button btnStart;
        private System.Windows.Forms.Timer timTime;
    }
}
